on the WSJ PTB To evaluate the perplexity of the LMs on the WSJ PTB task, we adopted the conventions of Chelba (2000), Roark (2001), and Charniak (2001) for preprocessing the data.
J01-2004 P01-1017
238-247. Proceedings of the Conference on Empirical Methods in Natural 2001; Roark, 2001) that incorporate syntactic information.
J01-2004
Heeman’s (1998) POS LM achieves a perplexity reduction compared to a trigram LM by instead rede ning the speech recognition problem as determining: W ;T = arg max W;T P(W;TjA) = arg max W;T P(W;T)P(AjW;T) arg max W;T P(W;T)P(AjW) where T is the POS sequence t N 1 associated with the word sequence W = w N 1 given the speech utterance A.TheLMP(W;T)isajoint probabilistic model that accounts for both the sequence of words w N 1 and their tag assignments t N 1 by estimating the joint probabilities of words and tags: P(w N 1 ;t N 1 )= N Y i=1 P(w i ;t i jw i−1 1 ;t i−1 1 )(2) Johnson (2001) and La erty et al.(2001) provide insight into why a joint model is superior to a conditional model.
P01-1042 W98-1121
ZPDG was evaluated on the Prague Dependency Treebank (Hajic, 1998) during the 1998 Johns Hopkins summer workshop (Hajic et al., 1998) and produced a much lower parsing accuracy (under 60%) than Collins’ probabilistic context-free grammar parser (80%) (Collins, 1996).
P96-1025
We have observed in several experiments that the number of SuperARVs does not grow signi cantly as training set size increases; the moderate-sized Resource Management corpus (Price et al., 1988) with 25,168 words produces 328 SuperARVs, compared to 538 SuperARVs for the 1 million word Wall Street Journal (WSJ) Penn Treebank set (Marcus et al., 1993), and 791 for the 37 million word training set of the WSJ continuous speech recognition task.
J93-2004
During parsing, the grammaticality of a sentence in a language de ned by a CDG is determined by applying a set of constraints to the possible role value assignments (Harper and Helzerman, 1995; Maruyama, 1990).
P90-1005
Perplexity LM 3gram Model Intp (Weight) r POS 167.14 142.55 142.55 (1.0) 0.95 SuperARV 167.14 118.35 118.35 (1.0) 0.92 cSuperARV 167.14 150.01 143.83 (0.65) 0.68 Chelba (2000) 167.14 158.28 148.90 (0.64) N/A Roark (2001) 167.02 152.26 137.26 (0.64) N/A Charniak (2001) 167.89 130.20 126.07 (0.64) N/A Chelba 167.14 153.76 147.70 (0.64) 0.73 Charniak 167.14 130.20 126.03 (0.64) 0.69 Table 2: Comparing perplexity results for each LM on the WSJ PTB test set.
J01-2004 P01-1017
In order to derive the constraints directly from CDG annotated sentences, we have developed an algorithm to extract grammar relations using information derived directly from annotated sentences (Harper et al., 2000; Harper and Wang, 2001).
A00-2014
Bod. 2001.
P01-1010
In order to compare our SuperARV LM with a word-based LM, we must use the following equation to calculate the word perplexity (PPL): PPL = 2 En (4) En − 1 N N X i=1 log 2 ^ P(w i jw i−1 i−2 ) − 1 N N X i=1 log 2 P t i−2;i ^ P(w i t i jw i−1 i−2 t i−1 i−2 ) ^ P(w i−1 i−2 t i−1 i−2 ) P t i−2;i−1 ^ P(w i−1 i−2 t i−1 i−2 ) Equation (4) is used by class-based LMs to calculate word perplexity (Heeman, 1998).
W98-1121
Originally, the constraints were comprised of a set of hand-written rules specifying which role values (unary constraints) and pairs of role values (binary constraints) were grammatical (Maruyama, 1990).
P90-1005
Collins. 1996.
P96-1025
Including need roles also provides a mechanism for using non-headword dependencies to constrain parse structures, which Bod (2001) has shown contributes to improved parsing accuracy.
P01-1010
Heeman. 1998.
W98-1121
Representing each multiplicand in Equation (3) as the conditional probability ^ P(xjy 1 ;y 2 ;:::;y n )wherey 1 ;y 2 ;:::;y n belong to a mixed set of words and SuperARVs, the recursive linear interpolation is calculated as follows: 1 We have annotated a moderate-sized corpus, DARPA Naval Resource Management (Price et al., 1988), with CDG parse relations as reported in (Harper et al., 2000; Harper and Wang, 2001).
A00-2014
Hence, during testing, a transformation converts the output of the recognizer to a form compatible with the text-based tokenization (Roark, 2001) for rescoring.
J01-2004
Note that for lattice rescoring, however, Roark found that Chelba’s model achieves a greater reduction on WER than his LM (Roark, 2001).
J01-2004
Although wordbased LMs (with bigram and trigram being the most common) remain the mainstay in many continuous speech recognition systems, recent e orts have explored a variety of ways to improve LM performance (Niesler and Woodland, 1996; Chelba et al., 1997; Srinivas, 1997; Heeman, 1998; Chelba, 2000; Rosenfeld, 2000; Goodman, 2001; Roark, 2001; Charniak, 2001).
J01-2004 P01-1017 W98-1121
For the WSJ PTB task, we compare the SuperARV LMs to the parser LMs developed by Chelba (2000), Roark (2001), and Charniak (2001).
J01-2004 P01-1017
