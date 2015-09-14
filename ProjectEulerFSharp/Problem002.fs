module Problem002

open ProjectEuler;

let answer =
    PEUtils.fibSeq
    |> Seq.takeWhile(fun x -> x < 4000000)
    |> Seq.filter(fun x -> x % 2 = 0)
    |> Seq.sum