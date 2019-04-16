﻿module ICPC
open System

(*this method finds words the in input*)
let Findwords (input : string) (index : int)= 
   
      
      let rec search statingIndex i =
        match input.[i] <> ' ' with
        | true -> search statingIndex (i+1)
        |  _ ->  
                 let foundword = input.[statingIndex..i-1] in
                 foundword
      search index (index)
              
let addcomma substring : string =
        
        let substring = substring + "," in
         substring


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

let setInput (input : string) (mystring : string)(*contains comma*) (indexToStartAt : int) (indexOfn : int) = //failwith "j"
                                
                            
                            let mystring = mystring.[..mystring.Length-2] // since it contains comma
                            let rec myf index =
                                 
                                let foundword = Findwords input index
                                let indexToStartAt = GetNextIndex input index
                                match indexToStartAt < input.Length with 
                                |true ->    match mystring = foundword with
                                             | true ->   let substring = input.[..indexOfn-1]
                                                         let LengthOfSub= substring.Length + foundword.Length
                                                         let rec fill i editedSubstring =
                                                               match i <> LengthOfSub with
                                                               | true -> fill (i+1) ( editedSubstring + (string)input.[i]) 
                                                               | false ->  editedSubstring
                                                         fill index substring
                                             | _ ->  myf (indexToStartAt)
                                |false -> input
                            myf indexToStartAt /// or  index to start at


                         
let commaSprinkler (input : string)  =
                      //  Findwords (input)
                       let indexToStartAt = 0;


                       let rec myf  index =

                       //recursion here-----------------------------------------------------------
                          let mystring = Findwords (input) (index)   // 1. find word in sentnce
                         // let isComma = IsComma mystring                  
                          let indexToStartAt = GetNextIndex input index in // 3. get the next index where we should start finding these words
                                   match mystring.EndsWith(',') && mystring.[mystring.Length-1] <> ('\t')  with       // 2. check if 1. has comma
                                   | false -> myf indexToStartAt
                                   | true ->  let nmystring = setInput input mystring indexToStartAt index
                                              nmystring
                       myf 0
                     

let rivers input =
    failwith "Not implemented"

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
