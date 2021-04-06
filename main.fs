module Assignment

type Tree =
    | Node of Tree * Tree
    | Leaf of int

let rec prod (t:Tree) :int =
    match t with
    | Leaf x -> x
    | Node (l,r) -> prod(l) * prod(r)

    //OO DID IT.

let rec map (f:int->int) (t:Tree) :Tree =
    match t with
    //| Leaf x -> (f x)
    | Node(l,r) -> map f l

let rec foldStr (nf:string -> string -> string) (lf:int->string) (t:Tree) :string =
    ""
