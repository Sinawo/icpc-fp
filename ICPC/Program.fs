﻿module ICPC
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
              //   let IsContainsPrecidingComma = IsComma foundword
 



let setInput (input : string) (mystring : string)(*contains comma*) (index : int) = failwith "j"
                                
                                //let rec myf 

                   

 (*this method returns the word which contains a comma or "NotFound" if there's no comma*)
let IsComma (word :string) =
          match word.[word.Length-1] = ',' with 
          | true -> word
          | _ -> "NotFound"
   
//let addCommaToConcurrencies input index =  failwith " kkkkk"
            //match input = "NotFound" with
            //| true -> 


let GetNextIndex (input : string) (index : int)=

     let rec search statingIndex i =
        match input.[i] <> ' ' with
        | true -> search statingIndex (i+1)
        |  _ ->  
                 let statingIndex = i+1 in
                 statingIndex
     search index index

let SucceedingComma (input : string)  (word : string) = failwith "kkk"
                  //     FindWords input
//                let rec addComma 
       

      // first string is found 
     
//     let rec findword word i =
//            let  = input.[i] 
//            match word.[i] <> ' ' with
//            | true -> findword word.[i] i+1
////            | _ -> 
//let FindNextWord (input:string) i= 
        
//       //  let rec findwords input i =

//                // first char in input
//              match input.[i] = ' ' with
//              | true -> 
//                         
//                         startingIndex = input.[i+1]
//                         foundword
                      
//              |  _ ->    ""


                         
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
                       //    match isComma with 
                       //    | true -> addCommaToConcurrencies 


                        
                     //  GetNextIndex (input) (0)


  //                        let rec space sentence n =
  //                            match input.[n] = ' ' with
  //                             | true ->  
  //                                      input + space sentence n+1
                        
  //                             | false ->    
  //                                      let next =  (FindNextWord (input) (n))  in
  //                                      let word  = findword + next in
  //                                                      next //  next + word
  //                        space input 0            
  // failwith "Not implemented"

let rivers input =
    failwith "Not implemented"

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
