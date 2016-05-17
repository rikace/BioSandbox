﻿

#r @"..\..\packages\FsCheck.2.4.0\lib\net45\FsCheck.dll"
#r @"..\..\packages\Alea.CUDA.2.2.0.3307\lib\net40\Alea.CUDA.dll"
#r @"..\..\packages\Alea.CUDA.Unbound.2.2.0.3307\lib\net40\Alea.CUDA.Unbound.dll"
#r @"C:\Git\BioSandbox\Graphs\DrawGraph\bin\Debug\DrawGraph.dll"
#I @"..\..\packages\Alea.CUDA.2.2.0.3307\lib\net40"
#I @"..\..\packages\Alea.CUDA.Unbound.2.2.0.3307\lib\net40"

#r @"Alea.CUDA"
#r @"Alea.CUDA.Unbound"

#load "dirGraph.fs"
open Graphs
open FsCheck
open System
open System.Text.RegularExpressions
open System.Diagnostics
open DirectedGraph

let strs = ["a -> b, c, d"; "b -> a, c"; "d -> e, f"; "e -> f"]
let strs1 = ["a -> c, d"; "b -> a, c"; "d -> e, f"; "e -> f"]

let gr = DirectedGraph.FromStrings strs
let gr1 = DirectedGraph.FromStrings strs1

printfn "%b" (gr = gr1)

gr.Visualize()

let dirg = DirectedGraph.GenerateEulerGraph 100 5

dirg.Visualize(emphasizeInConnections = 5, emphasizeOutConnections = 5)