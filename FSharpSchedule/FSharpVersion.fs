module FSharpSchedule

open RandomMonad

let Optimize (events: Schedule.Event array) numberOfIndividuals : RandomMonad.Rand<GA.ScoredIndividual seq> =
    let fitnessFunction = Schedule.athleticsScheduleCost events
    rand {

        let! initialPopulation = GA.randomIndividuals fitnessFunction  events.Length numberOfIndividuals
        return! GA.evolveForever fitnessFunction initialPopulation numberOfIndividuals
    }

let Run (events: Schedule.Event array) numberOfIndividuals: GA.ScoredIndividual seq =
    let random = new System.Random()
    RandomMonad.evaluateWith random (Optimize events numberOfIndividuals)
