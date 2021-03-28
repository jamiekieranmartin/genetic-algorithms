module TSP

open RandomMonad

// The location of a city 
type City = { x: int; y: int }

// Generate a city at a random location
let randomCity width height: Rand<City> = 
    rand {
        let! randomX = intRange 0 width
        let! randomY = intRange 0 height
        return { x = randomX; y = randomY }
    }

// generate a set of count cities at random locations
let generateRandomCities (count:int) : Rand<City array> =
    randArrayInit count (fun i -> randomCity 800 800)

// Determine the distance between two cities using Pythagoras theorem
let distance (cityA: City) (cityB: City) : float =
    let square x = x * x
    sqrt (float (square (cityA.x - cityB.x) + square (cityA.y - cityB.y)))

// Determine the total length of the path if the cities are visited in the specified order.
let TSPCost (cities: City array) =
    let costFunction (order: int array) =
        let shiftedOrder = Array.init order.Length (fun i -> if i+1 < order.Length then order.[i+1] else order.[0])
        Array.map2 (fun prev next -> distance cities.[prev] cities.[next]) order shiftedOrder
        |> Array.sum
        |> (fun length -> - length) // take the negative of the length so that a shorter path length is considered as better
    costFunction