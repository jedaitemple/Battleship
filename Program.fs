// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]

let main argv =
    let arr = array2D [| [| 0..9 |]; [| 0..9 |];[| 0..9 |];[| 0..9 |] ;[| 0..9 |] ;[| 0..9 |] ;[| 0..9 |];[| 0..9 |];[| 0..9 |];[| 0..9 |];  |]  
  //I don't really nead this array
    let initiateBoard=
          let random = new System.Random()
         
          let getString  final =
           let mutable mystr=""
           let mutable final1=final/10
           
           let mutable finall1=final%10
           if(final1=0)then
               begin
                  printf"A"
                  printfn"%A" finall1
                    
               end
           else if(final1=1)then
            begin
              
               printf"B"
               printfn"%A" finall1
            end

            else if(final1=2)then
                    begin
                        printf"C"
                        printfn"%A" finall1
                    end
           else  if(final1=3)then
                    begin
                        printf"D"
                        printfn"%A" finall1
                    end
            else if(final1=4)then
                       begin
                      printf"E"
                      printfn"%A" finall1
                        end
            else if(final1=5)then
                          begin
                       printf"F"
                       printfn"%A" finall1
                            end
            else if(final1=6)then
                        begin
                        printf"G"
                        printfn"%A" finall1
                         end
            else if(final1=7)then
                               begin
                            printf"H"
                            printfn"%A" finall1
                               end
            else if(final1=8)then
                               begin
                           printf"I"
                           printfn"%A" finall1
                              end
            else if(final1=9)then
                     begin
                     printf"J"
                     printfn"%A" finall1
                         end
           0

            

          let getSTR lastChar=
           
          
           if(lastChar='0')then 
                 begin
                    let myint=0
                    myint
                 end

           else if(lastChar='1')then 
                begin
                   let myint=1
                   myint
                   
                end
           else if(lastChar='2')then 
                begin
                   let myint=2
                   myint
                end
           else if(lastChar='3')then 
                begin
                   let myint=3
                   myint
                   
                end
           else if(lastChar='4')then 
                begin
                   let myint=4
                   myint
                   
                end
           else if(lastChar='5')then 
               begin
                  let myint=5
                  myint
                  
               end
           else  if(lastChar='6')then 
                begin
                   let myint=6
                   myint
                   
                end
           else if(lastChar='7')then 
                begin
                   let myint=7
                   myint
                   
                end
           else if(lastChar='8')then 
                begin
                   let myint=8
                   myint
                   
                end
           else if(lastChar='9')then 
               begin
                  let myint=9
                  myint
                 
               end
               else
               0
          let Battleship1 V1 V=
               
                 if(V>=50) then 
                                 
                                  
                                    let arr1 = [|
                                                  V-40
                                                  V-30
                                                  V-20
                                                  V-10
                                                  V 
                                                  |]
                                    arr1
                  else   
                  
                     
                                  let arr1 =  [|
                                                 V+40
                                                 V+30
                                                 V+20
                                                 V+10
                                                 V
                                                 |]
                                  arr1


          //printfn "%A" C1
          let Destroyer1 V1 V=
              
                if(V>=50) then 
                                
                                 
                                   let arr1 = [|
                                                 V-30
                                                 V-20
                                                 V-10
                                                 V 
                                                 |]
                                   arr1
                 else   
                 
                    
                                 let arr1 =  [|
                                                V+30
                                                V+20
                                                V+10
                                                V
                                                |]
                                 arr1
          let Battleship V1 V=
              
                if(V1>=5) then 
                                
                                 
                                   let arr1 = [|
                                                 V-4
                                                 V-3
                                                 V-2
                                                 V-1
                                                 V 
                                                 |]
                                   arr1
                 else   
                 
                    
                                 let arr1 =  [|
                                                V+4
                                                V+3
                                                V+2
                                                V+1
                                                V
                                                |]
                                 arr1
          
          let Destroyer V1 V=
          
            if(V1>=5) then 
                            
                             
                               let arr1 = [|
                                             V-3
                                             V-2
                                             V-1
                                             V 
                                             |]
                               arr1
             else   
             
                
                             let arr1 =  [|
                                            V+3
                                            V+2
                                            V+1
                                            V
                                            |]
                             arr1
          let   Generate  a b c =
          
          
           let C1=c%10
           let mutable B1=b%10
           let A1=a%10
           let mutable  arr1=[||]

           let   up_down1 () = random.Next(0, 2)
           let   up_down1=up_down1()
           if(up_down1=0)then
            arr1 <- Battleship  A1 a
            printfn " "
           else
             arr1<-Battleship1 A1 a
             printfn " "
          
           let mutable arr2 = [||]
           let  up_down2 () = random.Next(0, 2)
           let   up_down2=up_down2()
           if(up_down2=0)then
                    arr2 <- Destroyer  B1 b
                    printfn " "
                   else
                     arr2<-Destroyer1 B1 b
                     printfn " "
           let exists a b = Array.exists (Set.ofArray arr1).Contains arr2
         
           let mutable flagg=0
           while(flagg=0)do
             begin
             if(exists arr1 arr2=false) then
                begin
                  flagg<-1
               end
             if(flagg=0) then
               begin
                   let b () = random.Next(0, 99)
                   let B=b()
                   let B1=B%10
                   if(up_down2=0)then
                                      arr2 <- Destroyer  B1 B
                                      printfn " "
                                     else
                                       arr2<-Destroyer1 B1 B
                                       printfn " "
               end
            end
           let merged = Array.append arr1 arr2
          
           let mutable  arr3=[||]

           let   up_down3 () = random.Next(0, 99)
           let   up_down3=up_down3()
           if(up_down3=0)then
                    arr3 <- Destroyer  C1 c
                    printfn " "
                   else
                     arr3<-Destroyer1 C1 c
                     printfn " "

           let exists a b = Array.exists (Set.ofArray merged).Contains arr3
           let mutable flagg=0
           while(flagg=0)do
                   begin
                   if(exists arr3 merged=false) then
                      begin
                        flagg<-1
                     end
                   if(flagg=0) then
                     begin
                         let c() = random.Next(0, 99)
                         let C=c()
                         let C1=C%10
                         if(up_down3=0)then
                                     arr3 <- Destroyer  C1 C
                                     printfn " "
                                        else
                                      arr3<-Destroyer1 C1 C
                                      printfn " "
                     end
                  end
          
           let merged1 =Array.append merged arr3
           merged1
          
          let rand = new Random()
          let acomp() =
           rand.Next(0,99)
          let a= acomp()
          let rand = new Random()
          let bcomp() =
           rand.Next(0,99)
          let b = bcomp()
          let rand = new Random()
          let ccomp() =
           rand.Next(0,99)
          let c = ccomp()
          let rand = new Random()
          let Acomp() =
           rand.Next(0,99)
          let acomp= acomp()
          let rand = new Random()
          let Bcomp() =
           rand.Next(0,99)
          let bcomp = bcomp()
          let rand = new Random()
          let Ccomp() =
           rand.Next(0,99)
          let ccomp = ccomp()
          let  merged1comp= Generate a b c
          
          let  merged1= Generate acomp bcomp ccomp
          //printfn "%A" merged1
          //printfn "%A" merged1comp
          let mutable hitt=[||]
     
          let mutable counter=0
          let mutable flag=0
          let mutable hittcomp=[||]
              
          let mutable countercomp=0
          let mutable flagcomp=0
          while (counter < 13 && countercomp<13) do
                begin
                
                let s = Console.ReadLine()
                let firstChar = s.[0]
                let lastChar =s.[1]
                //let mutable someInt=0
                let mutable Final=0
                
                //printfn "%A" lastChar
                if(firstChar='A')then 
                 begin
                     let someInt=getSTR lastChar
                     Final<-someInt

                 end
                else if(firstChar='B')then 
                   begin
                       let someInt=getSTR lastChar
                       Final<-someInt+10

                   end
                if(firstChar='C')then 
                         begin
                               let someInt=getSTR lastChar
                               Final<-someInt+20

                                     end
                if(firstChar='D')then 
                        begin
                            let someInt=getSTR lastChar
                            Final<-someInt+30

                                                    end
                if(firstChar='E')then 
                         begin
                              let someInt=getSTR lastChar
                              Final<-someInt+40

                               end
                if(firstChar='F')then 
                    begin
                    let someInt=getSTR lastChar
                    Final<-someInt+50

                end
                if(firstChar='G')then 
                    begin
                    let someInt=getSTR lastChar
                    Final<-someInt+60

                end
                if(firstChar='H')then 
                    begin
                    let someInt=getSTR lastChar
                    Final<-someInt+70

                end
                if(firstChar='I')then 
                    begin
                    let someInt=getSTR lastChar
                    Final<-someInt+80

                end
                if(firstChar='J')then 
                    begin
                    let someInt=getSTR lastChar
                    Final<-someInt+90

                end

                for i in 0.. hitt.Length - 1 do
                              begin
                              if(Final=hitt.[i]) then
                                   begin 
                                      flag<-2
                                              // printf "Already tipped"
                                   end
                              end

                if(flag=0)then
                 begin
                  for i in 0 .. merged1.Length - 1 do
                    begin
                     if(Final=merged1.[i]) then
                        begin
                         flag<- 1
                        
                         if(flag=1) then
                          begin
                           counter<-counter+1

                           
                          // printf "HITT" 
                           end
                       
                       end

                     end
                     end
                hitt<-Array.append hitt [|Final|]
                if(flag=0 )then
                   begin 
                   printfn" You missed"
                                     
                   end
                   else if flag=1 then
                    begin
                    printfn "You hit"
                   
                    end
                    else if flag=2 then
                     begin
                     printfn "Already tipped"
                     end
                flag<-0 
                

                let Finalcomp = random.Next(0, 99)
               // printfn "%A" Finalcomp
                let a= getString Finalcomp
                

                for i in 0.. hittcomp.Length - 1 do
                              begin
                              if(Finalcomp=hittcomp.[i]) then
                                   begin 
                                      flagcomp<-2
                                              // printf "Already tipped"
                                   end
                              end

                if(flagcomp=0)then
                 begin
                  for i in 0 .. merged1comp.Length - 1 do
                    begin
                     if(Finalcomp=merged1comp.[i]) then
                        begin
                         flagcomp<- 1
                        
                         if(flagcomp=1) then
                          begin
                           countercomp<-countercomp+1

                           
                          // printf "HITT" 
                           end
                       
                       end

                     end
                     end
              
                hittcomp<-Array.append hittcomp [|Finalcomp|]
                if(flagcomp=0 )then
                   begin 
                   
                         printfn" computer missed"
                            
                   end
                   else if flagcomp=1 then
                    begin
                    printfn "computer hit"
                   
                    end
                    else if flagcomp=2 then
                     begin
                     printfn "computer Already tipped"
                     end
                flagcomp<-0     

               
             end
          if(counter>countercomp) then 
                    begin
                    printfn("You win")
                    printfn "End of Game"
                    end else
                    printfn"Computer Win"
    
         

         

          
         
            

    

    0 // return an integer ex
