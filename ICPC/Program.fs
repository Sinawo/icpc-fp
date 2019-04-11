module ICPC
open System

(*this method finds words the in input*)
let FindWords (input : string) = 
   
      
      let rec search statingIndex i =
        let firstCharForNext = input.[statingIndex]   /////
        match input.[i] <> ' ' with
        | true -> search statingIndex (i+1)
        |  _ ->  
                 let foundword = input.[input.IndexOf(firstCharForNext)..i-1] in
                 let statingIndex = i+1 in
                 foundword
      search 0 0
              //   let IsContainsPrecidingComma = IsComma foundword
 
 (*this method returns the word which contains a comma or "NotFound" if there's no comma*)
let IsComma (word :string) =
          match word.EndsWith(',') with 
          | true -> word
          | _ -> "NotFound"
   
let addCommaToConcurrencies input index = failwith " kkkkkkkk"

let GetNext (input : string) (index : int ) =

     let rec search statingIndex i =
        let firstCharForNext = input.[statingIndex]   /////
        match input.[i] <> ' ' with
        | true -> search statingIndex (i+1)
        |  _ ->  
                 let foundword = input.[input.IndexOf(firstCharForNext)..i-1] in
                 let statingIndex = i+1 in
/////////////////////////////////////////////////////////////////////////////////////////////////////////////
                 match IsComma foundword with 
                 | foundword -> addCommaToConcurrencies foundword statingIndex
                 | _ -> search statingIndex i+1

                
     search 0 0

let SucceedingComma (input : string)  (word : string) =
                       FindWords input
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


                         
let commaSprinkler (input:string)  =
                       GetNext (input) (0)


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
