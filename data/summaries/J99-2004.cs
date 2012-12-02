Parsers Pioneered by the IBM natural language group (Fujisaki et al.1989) and later pursued by, for example, Schabes, Roth, and Osborne (1993), Jelinek et al.(1994), Magerman (1995), Collins (1996), and Charniak (1997), this approach decouples the issue of wellformedness of an input string from the problem of assigning a structure to it.
E93-1040 H94-1052 P95-1037 P96-1025
4. Supertags Part-of-speech disambiguation techniques (POS taggers) (Church 1988; Weischedel et al.1993; Brill 1993) are often used prior to parsing to eliminate (or substantially reduce) the part-of-speech ambiguity.
A88-1019 J93-2006 P93-1035
We use word features similar to the ones used in Weischedel et al.(1993), such as capitalization, hyphenation, and endings of words, for estimating the word emit probability of unknown words.
J93-2006
The first set has been collected by parsing the Wall Street Journal 7, IBM Manual, and ATIS corpora using the wide-coverage English grammar being developed as part of the XTAG system (Doran et al.1994). The correct derivation from all the derivations produced by the XTAG system was picked for each sentence from these corpora.
C94-2149
There are also parsers that use probabilistic (weighting) information in conjunction with hand-crafted grammars, for example, Black et al.(1993), Nagao (1994), Alshawi and Carter (1994), and Srinivas, Doran, and Kulick (1995).
J94-4005 P93-1005
6.6 Error-driven Transformation-based Tagger In an error-driven transformation-based (EDTB) tagger (Brill 1993), a set of patternaction templates that include predicates that test for features of words appearing in the context of interest are defined.
P93-1035
The XTAG system consists of a morphological analyzer, a part-of-speech tagger, a wide-coverage LTAG English grammar, a predictive left-to-right Earley-style parser for LTAG (Schabes 1990), and an X-windows interface for grammar development (Doran et al.1994). The input sentence is subjected to morphological analysis 258 Bangalore and Joshi Supertagging Sr \[agr : <1> \[ 3rdsing : 4 / I "m: singll \[mode : <2> lnd J \[agr: <1>\] llrPr \[agr: <1> 1 \[mode : <2:>\] DeIP \[agr: <1>\] N \[agr: <1>\] V \[agr: <1> \] VP \[:~, <.3> c~ 1 \[mode : <2>J tmode : <4> ge~ \[mode : <4>J \[mode : <6> ppartJ \[ i I \[mode : <6>J I acquired (~) ~nxlV \[acquired\] acquired aNXdxN \[company\] ~Vvx \[being\] company being ! I I I ~DXD \[the\] fWvx \[is\] the is (b) (c) Figure 8 (a) Derived tree, (b) derivation tree, and (c) dependency tree for the sentence: the company is being acquired.
C94-2149
For LFG, the lexicalized subset of fragments used in the LFG-DOP model (Bod and Kaplan 1998) can be seen as supertags.
P98-1022
This approach has proved to be quite successful as a preprocessor in information extraction systems (Hobbs et al.1995; Grishman 1995).
M95-1014
6.5 N-gram Model We first explored the use of trigram model of supertag disambiguation in Joshi and Srinivas (1994).
C94-1024
FB-LTAGs trace their lineage to Tree Adjunct Grammars (TAGs), which were first developed in Joshi, Lev36 and Takahashi (1975) and later extended to include unification-based feature structures (Vijay-Shanker 1987; Vijay-Shanker and Joshi 1991) and lexicalization (Schabes, AbeillG and Joshi 1988).
C88-2121
We first employed these ideas in the context of Lexicalized Tree Adjoining grammars (LTAG) in Joshi and Srinivas (1994).
C94-1024
description of the part-of-speech tags is provided in Marcus, Santorini, and Marcinkiewicz (1993).
J93-2004
Lexical information contributes most to the performance of a POS tagger, since the baseline performance of assigning the most likely POS for each word produces 91% accuracy (Brill 1993).
P93-1035
2.1 Finite-State-Grammar-based Parsers Finite-state-grammar-based approaches to parsing are exemplified by the parsing systems in Joshi, (1960), Abney (1990), Appelt et al.(1993), Roche (1993), Grishman (1995), Hobbs et al.(1997), Joshi and Hopely (1997), and Karttunen et al.(1997). These systems use grammars that are represented as cascaded finite-state regular expression recognizers.
M95-1014 M95-1019
As mentioned earlier, a lexicalized grammar parser can be conceptualized to consist of two stages (Schabes, AbeillG and Joshi 1988).
C88-2121
Since first reported in Joshi and Srinivas (1994), we have not continued experiments using this model of supertagging, primarily for two reasons.
C94-1024
Work As reported in Joshi and Srinivas (1994), we experimented with a trigram model as well as the dependency model for supertag disambiguation.
C94-1024
Feature-based Lexicalized Tree Adjoining Grammar (FB-LTAG) (Joshi, Levy, and Takahashi 1975; Vijay-Shanker 1987; Schabes, AbeillG and Joshi 1988; Vijay-Shanker and Joshi 1991; Joshi and Schabes 1996) is a tree-rewriting grammar formalism unlike context-free grammars and head grammars, which are string-rewriting formalisms.
C88-2121
The idea of supertagging can also be applied to a grammar in HPSG formalism indirectl~ by compiling the HPSG grammar into an LTAG grammar (Kasper et al.1995). A more direct approach would be to tag words with feature structures that represent supertags (Kempe 1994).
C94-1025 P95-1013
For the IBM Manual corpus and the ATIS domains, a supertag annotated corpus was collected using the parses of the XTAG system (Doran et al.1994) and selecting the correct analysis for each sentence.
C94-2149
Since there is only one supertag for each word (assuming there is no global ambiguity) when the parse is complete, an LTAG parser (Schabes, Abeill6, and Joshi 1988) needs to search a large space of supertags to select the right one for each word before combining them for the parse of a sentence.
C88-2121
The words are first assigned standard parts of speech using a conventional tagger (Church 1988) and then are assigned supertags according to the unigram model.
A88-1019
An approach that is closely related to supertagging is the reductionist approach to parsing that is being carried out under the Constraint Grammar framework (Karlsson et al.1994; Voutilainen 1994; Tapanainen and J/irvinen 1994).
C94-1104
A more detailed discussion about these properties is presented in Joshi (1985, 1987), Kroch and Joshi (1985), Schabes, AbeillG and Joshi (1988), and Joshi and Schabes (1996).
C88-2121
7. Supertagging before Parsing The output of the supertagger, an almost parse, has been used in a variety of applications including information retrieval (Chandrasekar and Srinivas 1997b, 1997c, 1997d) and information extraction (Doran et al.1997), text simplification (Chandrasekar, Doran, and Srinivas 1996, Chandrasekar and Srinivas 1997a), and language modeling (Srinivas 1996) to illustrate that supertags provide an appropriate level of lexical description needed for most applications.
C96-2183
The lexicon plays a central role in linguistic formalisms such as LFG (Kaplan and Bresnan 1983), GPSG (Gazdar et al.1985), HPSG (Pollard and Sag 1987), CCG (Steedman 1987), Lexicon Grammar (Gross 1984), LTAG (Schabes and Joshi 1991), Link Grammar (Sleator and Temperley 1991), and some version of GB (Chomsky 1992).
P84-1058
We do this not only to show the improvements made to the early work reported in our 1994 paper (Joshi and Srinivas 1994), but also to explain the rationale for choosing certain models of supertag disambiguation over others.
C94-1024
We have implemented a broad coverage CCG grammar (Doran and Srinivas 1994) containing about 80 categories based on the XTAG English grammar.
C94-2149
