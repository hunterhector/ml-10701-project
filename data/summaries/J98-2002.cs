Hindle and Rooth (1991) proposed the use of the lexical association measure calculated based on such doubles.
P91-1030
2.2 Class-based Models An example of the class-based approach is Resnik's method of generalizing values of a case frame slot using a thesaurus and the so-called selectional association measure (Resnik 1993a, 1993b).
H93-1054
For example, Brill and Resnik, (1994) propose a method they call transformation-based error-driven learning (see also Brill \[1995\]).
C94-2195 J95-4004
We used the bracketed corpus of the Penn Treebank (Wall Street Journal corpus) (Marcus, Santorini, and Marcinkiewicz 1993) as our data.
J93-2004
The problem of deciding whether to stop generalizing at BIRD and bee, or generalizing further to ANIMAL has been addressed by a number of authors (Webster and Marcus 1989; Velardi, Pazienza, and Fasolo 1991; Nomiyama 1992).
C92-2107 J91-2002 P89-1022
Coverage(%) Accuracy(%) Default 100 56.2 MDL + Default 100 82.2 SA + Default 100 76.7 LA + Default 100 80.7 LA.t + Default 100 78.1 TEL 100 82.4 We also implemented the exact method proposed by Hindle and Rooth (1991), which makes disambiguation judgement using the t-score.
P91-1030
In our experiments, described below, we compare the performance of our proposed method, which we refer to as MDL, against the methods proposed by Hindle and Rooth (1991), Resnik (1993b), and Brill and Resnik (1994), referred to respectively as LA, SA, and TEL.
C94-2195 H93-1054 J93-1005 P91-1030
As Resnik (1993b) pointed out, if we hope to improve disambiguation performance by increasing training data, we need a richer model such as those used in MDL and SA.
H93-1054
Some of these methods make use of prior knowledge in the form of an existing thesaurus (Resnik 1993a, 1993b; Framis 1994; Almuallim et al.1994; Tanaka 1996; Utsuro and Matsumoto 1997), while others do not rely on any prior knowledge (Pereira, Tishby, and Lee 1993; Grishman and Sterling 1994; Tanaka 1994).
A97-1053 C94-2116 C94-2119 C96-2159 H93-1054 P93-1024
It is potentially useful in other natural language processing tasks, such as the problem of estimating n-gram models (Brown et al.1992) or the problem of semantic tagging (Cucchiarelli and Velardi 1997).
A97-1055 J92-4003
As Resnik (1993b) pointed ~ P(qv,r) out, the use of selectional association Iu~ ~ seems to be appropriate for cognitive modeling.
H93-1054
V. R)), accurate 1 Recently, MDL and related techniques have become popular in corpus-based natural language processing and other related fields (Ellison 1991, 1992; Cartwright and Brent 1994; Stolcke and Omohundro 1994; Brent, Murthy, and Lundberg 1995; Ristad and Thomas 1995; Brent and Cartwright 1996; Grunwald 1996).
P95-1030 W94-0208
Thorough treatment of this problem is beyond the scope of the present paper; we simply note that one can employ an existing word-sense disambiguation technique (e.g.,Yarowsky 1992, 1994) in preprocessing, and use the disambiguated word senses as virtual words in the following 220 Li and Abe Generalizing Case Frames ANIMAL BIRD INSECT swallow crow eagle bird bug bee insect Figure 3 An example thesaurus.
C92-2070 P94-1013
The first approach (Hindle and Rooth 1991, 1993) takes doubles of the form (verb, prep) and (nounl, prep), like those in Table 9, as training data to acquire semantic knowledge and judges the attachment sites of the prepositional phrases in quadruples of the form (verb, nounl, prep, noun2) e.g., (see, girl, with, telescope)--based on the acquired knowledge.
J93-1005 P91-1030
The third approach (Brill and Resnik 1994; Ratnaparkhi, Reynar, and Roukos 1994; Collins and Brooks 1995) receives quadruples (verb, noun1, prep, noun2) and labels indicating which way the PP-attachment goes, like those in Table 11, and learns a disambiguation rule for resolving PP-attachment ambiguities.
C94-2195 H94-1048 J95-4004 W95-0103
For example, Resnik (1993a) proposes the use of the selectional association measure calculated based on such triples, as described in Section 2.
H93-1054
This is outside the scope of the present paper, and we simply refer the interested reader to one possible approach (Abe and Li 1996).
C96-1004
In this paper, we confine ourselves to the former issue, and refer the interested reader to Li and Abe (1996), which deals with the latter issue.
C96-1004
For the extraction problem, there have been various methods proposed to date, which are quite adequate (Hindle and Rooth 1991; Grishman and Sterling 1992; Manning 1992; Utsuro, Matsumoto, and Nagao 1992; Brent 1993; Smadja 1993; Grefenstette 1994; Briscoe and Carroll 1997).
A97-1052 A97-1053 C92-2088 C92-2099 J93-1005 J93-1007 J93-2002 P91-1030 P93-1032
Abe and Li \[1996\]).
C96-1004
In our experiments, we extracted verbs and their case frame slots (verb, slot_name, slot_value triples) from the tagged texts of the Wall Street Journal corpus (ACL/DCI CD-ROM1) consisting of 126,084 sentences, using existing techniques (specifically, those in Smadja \[1993\]), then 9 There are several possible measures that one could take to address this issue, including the incorporation of absolute frequencies of the words (inside and outside the particular slot in question).
J93-1007
It has been empirically verified that the use of lexical semantic knowledge is effective in structural disambiguation, such as the PP-attachment problem (Hobbs and Bear 1990; Whittemore, Ferrara, and Brunner 1990).
C90-3029 P90-1004
To address this problem, Grishman and Sterling (1994) proposed a method of smoothing conditional probabilities using the probability values of similar words, where the similarity between words is judged based on co-occurrence data (see also Dagan, Marcus, and Makovitch \[1992\] and Dagan, Pereira, and Lee \[1994\]).
C94-2119 P94-1038
For example, 2 The model used by Pereira, Tishby, and Lee (1993) is indeed along this direction.
P93-1024
As we remarked earlier, however, the input data required by our method (triples) could be generated automatically from unparsed corpora making use of existing heuristic rules (Brent 1993; Smadja 1993), although for the experiments we report here we used a parsed corpus.
J93-1007 J93-2002
The second approach (Sekine et al.1992; Chang, Luo, and Su 1992; Resnik 1993a; Grishman and Sterling 1994; Alshawi and Carter 1994) takes triples (verb, prep, noun2) and (nounl, prep, noun2), like those in Table 10, as training data for acquiring semantic knowledge and performs PP-attachment disambiguation on quadruples.
A92-1014 C94-2119 H93-1054 J94-4005 P92-1023
Training Data Average number of doubles per data set 91218.1 Average number of triples per data set 91218.1 Average number of quadruples per data set 21656.6 Test Data Average number of quadruples per data set 820.4 The generalization method we propose falls into the second category, although it can also be used as a component in a combined scheme with many of the above methods (see Brill and Resnik \[1994\], Alshawi and Carter \[1994\]).
C94-2195 J94-4005
