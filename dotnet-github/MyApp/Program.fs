namespace MyApp

open System.IO
open Argu

type ArgsFragments =
    | [<ExactlyOnce ; EqualsAssignmentOrSpaced>] Config_File of string

    interface IArgParserTemplate with
        member s.Usage =
            match s with
            | Config_File _ -> "a config file"

type Args =
    {
        ConfigFile : FileInfo
    }

module Program =

    [<EntryPoint>]
    let main argv =
        let parser = ArgumentParser.Create<ArgsFragments> ()
        let parsed = parser.Parse argv

        let args =
            {
                ConfigFile = parsed.GetResult ArgsFragments.Config_File |> FileInfo
            }

        0
