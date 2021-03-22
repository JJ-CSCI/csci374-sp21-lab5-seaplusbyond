module Assignment

type Tree =
    | Node of Tree * Tree
    | Leaf of int


//return the leaf's value to the previous node; use the value within the node to 
let rec prod (t:Tree) :int =
    match t with
    | Leaf x -> x
    | Node (l,r) -> prod(t)// should first look down a node's left side then it's right, but how would it determine if a side's been checked already?
    | _ -> 1 //if there's no nodes or something just give it a 1.

let rec map (f:int->int) (t:Tree) :Tree =
    t

let rec foldStr (nf:string -> string -> string) (lf:int->string) (t:Tree) :string =
    ""
