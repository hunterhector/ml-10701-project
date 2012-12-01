Typicallyinexample-basedmachinetranslation,either asingleTRecisretrievedfromtheTMbasedon a match with the overall L1 input, or the input is partitioned into coherent segments, and individual translations retrieved for each (Sato and Nagao, 1990; Nirenburg et al., 1993); this is the ﬁrststeptowardgeneratingacustomisedtranslationfortheinput.
C90-3044
While we have been able to conﬁrm the ﬁndingofBaldwinandTanaka(2000)thatcharacterbasedindexingissuperiortoword-basedindexing, wearenoclosertodeterminingwhythisshouldbe thecase.
C00-1006
Wethusfollowthelead ofBaldwinandTanaka(2000)inaskingthequestion: whatistheempiricaleﬀectonretrievalperformance of diﬀerent match approaches?
C00-1006
Variousoptimisationsweremadetoeachstring comparisonmethodtoreduceretrievaltime,ofthe type described by BaldwinandTanaka(2000).
C00-1006
This guaranteesauniquetranslationoutputanddiﬀersfrom the methodology of BaldwinandTanaka(2000), whojudgedthe systemoutputtobe “correct”if thepotentiallymultiplesetoftop-rankingoutputs containedanoptimaltranslation,placingmethods withgreaterfan-outofoutputsatanadvantage.
C00-1006
2 For3-operationedit distance, the edit distance between strings S = s 1 s 2...s m and T = t 1 t 2 ...t n is deﬁned as D 3op (S,T): D 3op (S,T)=d 3 (m,n) d 3 (i,j)=       0 if i =0∧j =0 d 3 (0,j− 1) + wt(t j ) if i =0∧j negationslash=0 d 3 (i − 1,0) + wt(s i ) if i negationslash=0∧j =0 min parenleftbigg d 3 (i − 1,j)+wt(s i ), d 3 (i,j − 1) + wt(t j ), m 3 (i,j) parenrightbigg otherwise m 3 (i,j)= braceleftBig d 3 (i − 1,j− 1) if s i = s j ∞ otherwise It is possible to normalise operation edit distance D 3op into 3-operation edit similarity S 3op bywayof: S 3op (S,T)=1− D 3op (S,T) len(S)+len(T) WeightedSequentialCorrespondence Weightedsequentialcorrespondence(originally proposedinBaldwinandTanaka(2000))goesone step further than edit distance in analysing not onlysegmentsequentiality,butalsothecontiguity ofmatchingsegments.
C00-1006
Weighted sequential correspondence associates an incremental weight (orthogonal to our wt weights)witheachmatchingsegmentassessingthe contiguity of left-neighbouring segments, in the manner described by Sato(1992) for characterbased matching.
C92-4203
Looking to past research on string comparison methods for TM systems, almost all systems involving Japanese as the source language rely on segmentation (Nakamura, 1989; Sumita and Tsutsumi, 1991; Kitamura and Yamamoto, 1996; Tanaka, 1997), with Sato(1992) and SatoandKawase(1994) providing rare instances of character-based systems.
C92-4203
Here again, our approachdiﬀers from that of BaldwinandTanaka(2000), whobased determination oftranslationoptimalityexclusivelyon 3-operationeditdistance(operatingoverwordunigrams), a method which we found to produce a strongbiastoward3-operationeditdistanceinL1 TR.
C00-1006
In analogous research, BaldwinandTanaka(2000) compared characterand word-based indexing within a Japanese– EnglishTRcontextandfoundcharacter-basedindexingtoholdaslightempiricaladvantage.
C00-1006
3 http://www.kecl.ntt.co.jp/icl/mtg/resources/altjaws.html 4.3 EvaluationoftheOutput Evaluationofretrievalaccuracyiscarriedoutaccordingtoamodiﬁedversionofthemethodproposed by BaldwinandTanaka(2000).
C00-1006
