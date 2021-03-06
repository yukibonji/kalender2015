open System

let dna = "TAACGAGTCTGCCACTAGATAGCCCGCGCTATTAATGGGATGTTCTAGGTCTTCACCTCGACCTATACAAGACGAGAAT
TCTGGTTCAGCCGGTCCGGGGTCGGGAGTTTGGCTTCATAACACAATTGCAGGCGTCAGAGGCCATACCTTAAACCCAT
CATACGACCGGTACGAAAATCCATGTCACAGACTAATGATCCCTGCTAAGAGATCGTAGCAACCGTTCTGGATCCAAGC
AGCTAATAAGTTAGCAAGCTGGTGTGTTTTTGATATTTGCAGTGGCAAACTGTTGCCTGGGTCGGTCCGATGGTCCTCA
TCGGACGCTGATGACGGACTTTGCACGGTCGCAAGTCGCTGATAGAAGGTGACTCTCGTGCACGATTTAGACCGGCAGT
GCTGCGTGAAGGGGGCTCCCTTATCTGATATGCGCAGACTATTTCGGCGTGGAATGCACATGTTCCCCGACCACTTCAA
CCCTCATGTTGAGGACTTCCTGCCATAACAACAGGGTAACTTAACTCAGGATGTCTTAAAAAAATAGGCTTCTCATGTG
CTCACATTTGGGACCGTATGTGCTAAACGGTGTACTATACGCGGTGGAATTTGGAATGGCAAACTTAACAGCAGGTCTA
ACCGTAGAAGACGTTACGAGTAAGTGTCAAGTCAGCATTGGCGGATCACGGCGTCGCTATGCCGTCAAGCTCTTTTGCG
GATATGATCTAAATCAGATTACGAGCGACGCCTGTTTCTAAAATGACCAATGGTACGCAACACGCTGGTAGGATCTGAG
CGAGCAAAGCATAAATAGACCCATCGTGTCGCCTGTAAATTGCAAGAGTACCAAGAACCCCGCAATTACGTTGGGTTCG
CTATAGTTGAAAGTTACCGATAAACTACCTTTCGCGACCCGTTTTATAACATAACTAGCATTATTACTCAAGGTGCTCT
GATTCCCAGAATACCCAAGAACTAGCGCGTTTTTATTTCTTTGGGGAGGTCTTGTCATGATGTTCATACTTGTCGCCTA
GGTTTGCCGACTTGTCCTTCTCTTACACTATTCCGAAATCGCAGTTGCACCACGATCGATGAGCATGGTAGTTACTTAA
ATATTCAAGAGTCCTGGTCCTCGAAATGGCATATGCTTGCAGGTGCCCCCGATCAGATAGAAGACCGCGGCCGAGGAGG
TAGTCCGGTACTGTGCGTTTGGTGCCTTTGACTCTTTACGCACTACTGGACCGGCCTTCGAGGTCTAAGGCTACGTCCT
TTAACGCTTTTACTATACAATAGAAGGTGTTCTACACACTGCGTGTCGCTGGATTGGCCTTCGACACGCCTTAGCGGCA
TGTATCAAGCTATCAGGGAGCCCATTGTGGGCGGTTACTCGTCGTTTGCACAACATCAGACCATTCACTATTAAGCTCA
TCCCCGAAGAAGGCACCCTACCGTTGTAAGTGCGACTTTGGAACCTCTCGGTAATGCCGGTTGCGGCACTTTCAACGTA
CATTCCGACCTAGTGCAGAAGAATGGATAGCGAGCTGTTTTTCGAGCTCTACCTAATCGGCTCGAATCTACTCGACGTG
TCGAGCGTCCTGTCGCATGGCTCGAAGCGGTATCGAGTCAGTCCCCCAGGGGCGCCGACACGTAGTGAGGTGAAAACAT
CGACATGTGCTTTTGATGTATATGGCTGAGCTTCAATGCGTGGCTAAAGTGGTCAATCCACTCAGGGCATGGATACTCG
GCTCAACATAGTAAATTGTCTCCGCGTCCGATAGGCGGGGGTCAATCCGCCGCACTGGTGGGTCACCCGTGATGCTAGG
TCTATAGCAGGGCCCCGACCGTAAACTTCAAGCTTTCCCGGTTGCTGTTGTTTTTTGAGCACAGGGAAACGAGCAGTAT
TGAATCTGAAGGGGGATAGGCGTTTAATTATTCAGAAGTAGTGCGAAGGGCTCCATATGACACTAGTCGTAGTAAGCAC
ATGCTGGAGGTCTGGACTTCCTTCG"

let result = 
    dna
    |> Seq.groupBy (fun c -> c)
    |> Seq.filter (fun (k,_) -> k <> '\n')
    |> Seq.sortBy (fun (k,_) -> k)
    |> Seq.map (fun (k, v) -> sprintf "%c%i" k (v |> Seq.length))
    |> String.concat ", "
