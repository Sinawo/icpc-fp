module ICPC
open System

(*this method finds words the in input*)
let Findwords (input : string) (index : int)= 
   
      
      let rec search statingIndex i =
        let firstCharForNext = input.[statingIndex]   /////
        match input.[i] <> ' ' with
        | true -> search statingIndex (i+1)
        |  _ ->  
                 let foundword = input.[statingIndex..i-1] in
                 foundword
      search index (index)
              
 



let setInput (input : string) (mystring : string)(*contains comma*) (index : int) = //failwith "j"
                                
                             let word =  in
                                word
                               let rec myf index =
                                let found = Findwords input index in
                                 match word.CompareTo(found) with
                                 | 1 -> 
                                       let input = input + "," + 
                                 
                                 | 2 -> myf index+1


                   

 (*this method returns the word which contains a comma or "NotFound" if there's no comma*)
let IsComma (word :string) =
          match word.[word.Length-1] = ',' with 
          | true -> word
          | _ -> "NotFound"
   


let GetNextIndex (input : string) (index : int)=

     let rec search statingIndex i =
        match input.[i] <> ' ' with
        | true -> search statingIndex (i+1)
        |  _ ->  
                 let statingIndex = i+1 in
                 statingIndex
     search index index

let SucceedingComma (input : string)  (word : string) = failwith "kkk"


                         
let commaSprinkler (input : string)  =
                      //  Findwords (input)
                       let indexToStartAt = 0;


                       let rec myf string index =

                       //recursion here-----------------------------------------------------------
                          let mystring = Findwords (input) (index)   // 1. find word in sentnce
                         // let isComma = IsComma mystring                  
                          let indexToStartAt = GetNextIndex input index in // 3. get the next index where we should start finding these words
                                   match mystring.EndsWith(',') && mystring.[mystring.Length-1] <> ('\t')  with       // 2. check if 1. has comma
                                   | false -> myf input indexToStartAt
                                   | true ->  let nmystring = setInput input mystring indexToStartAt 
                                              mystring
                       myf input 0
                     

let rivers input =
    failwith "Not implemented"

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
