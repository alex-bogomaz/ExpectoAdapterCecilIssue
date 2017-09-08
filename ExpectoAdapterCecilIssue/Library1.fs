namespace ExpectoAdapterCecilIssue

open Expecto

module Tests =
    (*[<Tests>]
    let testSimpleTests =
        testList "log record223" [
            testCase "equality no optional write async" <| fun () -> ()
            testCase "equality no optional write async2" <| fun () -> ()
    ]*)

    [<Tests>]
    let equality =
        testList "Aequality21"  [
            testCase "equality 3" <| fun () ->
                //Expect.isGreaterThan 3 3 ""
                Expect.equal 42 42 ""
                //Expect.isTrue false ""
            ]
