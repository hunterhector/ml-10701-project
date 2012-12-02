Furthermore, we found that the result presented in Dienes and Dubey (2003), i.e. pre-processing is better for antecedent recovery than unlexicalized in-processing, also holds when comparing lexicalized models.
P03-1055
In the TAGGER case, which is our main concern, the unlexicalized parser achieves an F-score of 72.6%, better than the 68.0% reported by Johnson (2002).
P02-1018
As with trace detection, we use the measure introduced by Johnson (2002).
P02-1018
Dienes and Dubey (2003) report 79a3 1% labeled F-score on this evaluation metric, the SBAR WHNPi what Sa4a6a5a8a7a10a9a6a11 NP j she VPa4a6a5a8a7a10a9a6a11a13a12a14a9a15a11a8a7a10a9a6a11 V wants Sa4a6a5a8a7a10a9a15a11a13a12a14a9a6a11a8a7a10a9a6a11 NPa9a6a11a8a7a10a9a6a11 NP–NPj VPa4a6a5a8a7a10a9a6a11 TO to VPa4a6a5a2a7a10a9a6a11 V buy NPa4a6a5a8a7a10a9a6a11 WH-NPi Figure 1: Threading gap+WH-NP and gap+NP-NP.
P03-1055
The pre-processing system does quite well, managing an F-score 6.6% higher than the post-processing system of Johnson (2002).
P02-1018
Even though this is a problem, our system still does quite well: 70.4% for NP–NP, and 69.5% for PRO–NP compared to the 60.0% and 50.0% reported by Johnson (2002).
P02-1018
(Clark et al., 2002; Riezler et al., 2002); and (iii) detecting non-local dependencies as a pre-processing step before parsing (Dienes and Dubey, 2003).
P02-1035 P02-1042 P03-1055
Three approaches have been proposed to detect such relations: (i) post-processing the output of a parser not designed to detect extraction sites (Johnson, 2002); (ii) integrating antecedent recovery into the parser (henceforth in-processing) by either enriching a syntactically simple model (Collins, 1999) or using a more powerful syntactic framework 1Collins (1999) can handle this case (Model 3).
P02-1018
In particular, Dienes and Dubey (2003) found that detecting EEs is infeasible with an unlexicalized parser: the parser was slow and inaccurate at EE detection.
P03-1055
In the experiments we use the same training, test, and development data as in Dienes and Dubey (2003), where non-local dependencies are annotated with the help of empty elements (EEs) co-indexed with their controlling constituents (if any).
P03-1055
empty elements Previous work (Dienes and Dubey, 2003) shows that detecting empty elements can be performed fairly reliably before parsing using a trace tagger, which tags words with information on EEs immediately preceding them.
P03-1055
While Dienes and Dubey (2003) report overall scores, they do not evaluate the relative importance of the features used by the tagger.
P03-1055
Rec. F-score Here Here Here Johnson OVERALL 81.5% 68.7% 74.6% 68.0% NP–NP 74.3% 67.4% 70.7% 60.0% WH–NP 91.0% 74.5% 82.0% 80.0% PRO–NP 68.7% 70.4% 69.5% 50.0% COMP–SBAR 93.8% 78.6% 85.5% 88.0% UNIT 99.1% 92.5% 95.7% 92.0% WH–S 86.3% 82.8% 84.5% 87.0% WH–ADVP 74.5% 42.0% 53.6% 56.0% CLAUSE 80.4% 68.3% 73.8% 70.0% COMP–WHNP 67.2% 38.3% 48.8% 47.0% Table 4: Comparison of our antecedent recovery results with the lexicalized parser and Johnson’s (2002).
P02-1018
as part of a larger syntactic pre-processing system, such as supertagging (Joshi and Bangalore, 1994); 3.
C94-1024
As noted by Dienes and Dubey (2003), unlexicalized parsing with EEs does not seem to be viable without pre-processing.
P03-1055
Table 4 gives a closer look at the antecedent recovery score for some common EE types using the lexicalized parser, also showing the results of Johnson (2002) for comparison.
P02-1018
Many broad-coverage statistical parsers (Charniak, 2000; Collins, 1999; Bod, 2001) are not able to give a full interpretation for sentences such as: (1) It is difficult to guess what she wants to buy.
A00-2018 P01-1010
As in Section 4, we use the unlexicalized parser from Dienes and Dubey (2003), and as a lexicalized parser, an extension of Model 3 of Collins (1999).
P03-1055
In addition to antecedent recovery, we also report parsing accuracy, using the bracketing F-Score, the combined measure of PARSEVAL-style labeled bracketing precision and recall (Magerman, 1995).
P95-1037
Section 4.3). 4.2 Method Antecedent recovery is tested using two parsers: an unlexicalized PCFG (Dienes and Dubey, 2003) and a lexicalized parser with near state-of-the-art performance (Collins, 1999).
P03-1055
Johnson (2002)’s metric includes EE without antecedents.
P02-1018
