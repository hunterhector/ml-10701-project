Parsers have been developed for a variety of grammar formalisms, for example HPSG (Toutanova et al., 2002; Malouf and van Noord, 2004), LFG (Kaplan et al., 2004; Cahill et al., 2004), TAG (Sarkar and Joshi, 2003), CCG (Hockenmaier and Steedman, 2002; Clark and Curran, 2004b), and variants of phrase-structure grammar (Briscoe et al., 2006), including the phrase-structure grammar implicit in the Penn Treebank (Collins, 2003; Charniak, 2000).
A00-2018 C04-1041 J03-4003 N04-1013 P02-1043 P04-1014 P04-1041 P06-2006 P06-4020
All the results were obtained using the RASP evaluation scripts, with the results for the RASP parser taken from Briscoe et al.(2006). The results for CCGbank were obtained using the oracle method described above.
P06-2006 P06-4020
Work The most common form of parser evaluation is to apply the Parseval metrics to phrase-structure parsers based on the Penn Treebank, and the highest reported scores are now over 90% (Bod, 2003; Charniak and Johnson, 2005).
E03-1005 P05-1022
Conversion to DepBank For the gold standard we chose the version of DepBank reannotated by Briscoe and Carroll (2006), consisting of 700 sentences from Section 23 of the Penn Treebank.
P06-2006 P06-4020
Different parsers produce different output, for example phrase structure trees (Collins, 2003), dependency trees (Nivre and Scholz, 2004), grammatical relations (Briscoe et al., 2006), and formalismspecific dependencies (Clark and Curran, 2004b).
C04-1010 C04-1041 J03-4003 P04-1014 P06-2006 P06-4020
249 3 The CCG Parser Clark and Curran (2004b) describes the CCG parser used for the evaluation.
C04-1041 P04-1014
The CCG parser results are based on automatically assigned POS tags, using the Curran and Clark (2003) tagger.
E03-1071
Preiss (2003) compares the parsers of Collins (2003) and Charniak (2000), the GR finder of Buchholz et al.(1999), and the RASP parser, using the Carroll et al.(1998) gold-standard.
A00-2018 E03-1025 J03-4003 W99-0629
In this paper we evaluate a CCG parser (Clark and Curran, 2004b) on the Briscoe and Carroll version of DepBank (Briscoe and Carroll, 2006).
C04-1041 P04-1014 P06-2006 P06-4020
Kaplan et al.(2004) clearly invested considerable time and expertise in mapping the output of the Collins parser into the DepBank dependencies, but they also note that “This conversion was relatively straightforward for LFG structures...
N04-1013
Briscoe and Carroll (2006) reannotated this resource using their GRs scheme, and used it to evaluate the RASP parser.
P06-2006 P06-4020
Previous evaluations of CCG parsers have used the predicate-argument dependencies from CCGbank as a test set (Hockenmaier and Steedman, 2002; Clark and Curran, 2004b), with impressive results of over 84% F-score on labelled dependencies.
C04-1041 P02-1043 P04-1014
Briscoe et al.(2006) split the 700 sentences in DepBank into a test and development set, but the latter only consists of 140 sentences which was not enough to reliably create the transformation.
P06-2006 P06-4020
The microaveraged scores are calculated by aggregating the counts for all the relations in the hierarchy, including the subsuming relations; the macro-averaged scores are the mean of the individual scores for each relation (Briscoe et al., 2006).
P06-2006 P06-4020
And third, we provide the first evaluation of a widecoverage CCG parser outside of CCGbank, obtaining impressive results on DepBank and outperforming the RASP parser (Briscoe et al., 2006) by over 5% overall and on the majority of dependency types.
P06-2006 P06-4020
Such conversions have been performed for other parsers, including parsers producing phrase structure output (Kaplan et al., 2004; Preiss, 2003).
E03-1025 N04-1013
Kaplan et al.(2004) compare the Collins (2003) parser with the Parc LFG parser by mapping LFG Fstructures and Penn Treebank parses into DepBank dependencies, claiming that the LFG parser is considerably more accurate with only a slight reduction in speed.
J03-4003 N04-1013
The GRs are described in Briscoe and Carroll (2006) and Briscoe et al.(2006). Table 1 lists the GRs used in the evaluation.
P06-2006 P06-4020
The overall F-score for the CCG parser, 81.86%, is only 3 points below that for CCGbank, which pro1The GRs are arranged in a hierarchy, with those in Table 1 at the leaves; a small number of more general GRs subsume these (Briscoe and Carroll, 2006).
P06-2006 P06-4020
The B&C scheme is similar to the original DepBank scheme (King et al., 2003), but overall contains less grammatical detail; Briscoe and Carroll (2006) describes the differences.
P06-2006 P06-4020
The results in Table 4 were obtained by parsing the sentences from CCGbank corresponding to those in the 560-sentence test set used by Briscoe et al.(2006). We used the CCGbank sentences because these differ in some ways to the original Penn Treebank sentences (there are no quotation marks in CCGbank, for example) and the parser has been trained on CCGbank.
P06-2006 P06-4020
Briscoe and Carroll (2006) give a rough comparison of RASP with the Parc LFG parser on the different versions of DepBank, obtaining similar results overall, but they acknowledge that the results are not strictly comparable because of the different annotation schemes used.
P06-2006 P06-4020
In the case of Kaplan et al.(2004), the testing procedure would include running their conversion process on Section 23 of the Penn Treebank and evaluating the output against DepBank.
N04-1013
