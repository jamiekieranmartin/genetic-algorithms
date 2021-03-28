module RandomMonad

// Internal wrapper type for the Random Monad
type Rand<'a> = RandomWrapper of (System.Random -> 'a)

// Evaluate a random value by providing a random number generator
let evaluateWith (random: System.Random) (randA: Rand<'a>) : 'a =
    let (RandomWrapper randomFunction) = randA
    randomFunction random

// A computational expression builder for wrapping random value generation
type RandBuilder() =
    member x.Bind(randA:Rand<'a>, f:'a->Rand<'b>): Rand<'b> =
       RandomWrapper (fun random ->
            let a = evaluateWith random randA
            let b = f a
            evaluateWith random b)
    member x.Return(a:'a) : Rand<'a> = 
        RandomWrapper (fun random -> a)
    member x.ReturnFrom(m:Rand<'a>) : Rand<'a> = m

// To be used to create computational expressions
let rand = new RandBuilder()

// Generate a random integer i such that min <= i < max
let intRange (min:int) (max:int): Rand<int> =
    RandomWrapper (fun random -> random.Next(min, max))

// Return true with probability p
let withProbability (p: double) : Rand<bool> =
    RandomWrapper (fun random -> random.NextDouble() <= p)

// Use a random element generator function to create an array of count random values of type T
let randArrayInit (count: int) (initFunction: int -> Rand<'T>) : Rand<'T array> =
    RandomWrapper (fun random -> Array.init count (fun i -> evaluateWith random (initFunction i)))

// Similar to Array.unfold but the generator provides random values
let rec randArrayUnfold (randomGenerator:'State -> Rand<Option<'T * 'State>>) (initialState:'State): Rand<'T array> =
    RandomWrapper (fun random ->
        let generator state = evaluateWith random (randomGenerator state)
        Array.unfold generator initialState)

// Similar to Seq.unfold but the generator provides random values.
// This version generates only infinite sequences, i.e. the generator never returns None.
let randSeqUnfold (randomGenerator:'State -> 'T * Rand<'State>) (initialState:'State) : Rand<'T seq> =
    RandomWrapper (fun random ->
        let generator state = 
            let (nextValue, nextState) = randomGenerator state
            Some (nextValue, evaluateWith random nextState) 
        Seq.unfold generator initialState)

// Choose an element from the list at random
let chooseRandom (list: 'T array): Rand<'T> =
    rand {
        let! index = intRange 0 list.Length
        return list.[index]
    }

// Randomly reorder the elements of the collection. 
// Every possible permuation should have the same probability of occurring
let shuffle (collection: 'T array) : Rand<'T array> =
    let pickNext (chooseFrom: 'T array): Rand<Option<'T * 'T array>> =
        rand {
            if (Array.isEmpty chooseFrom) then
                return None
            else
                let! next = chooseRandom chooseFrom
                let remaining = Array.filter (fun c -> c <> next) chooseFrom
                return Some (next, remaining)
        }
    randArrayUnfold pickNext collection

// Generate a random permutation of length N
let randomPermutation (N: int): Rand<int array> =
    shuffle (Array.init N id)