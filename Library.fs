namespace StackLibrary

type 'a Stack = 'a list
[<CompilationRepresentation(CompilationRepresentationFlags.ModuleSuffix)>]
[<RequireQualifiedAccess>]
module Stack =
    let empty: _ Stack = []
    let isEmpty = List.isEmpty empty
    let push x stack = x::stack : _ Stack
    let pop stack =
        match stack with
        | x::xs -> x, (xs: _ Stack)
        | [] -> failwithf "Stack is empty!"
