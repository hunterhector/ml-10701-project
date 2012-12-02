Many tasks in automatic speech recognition can be viewed as simple translations from acoustic sequences to sublexical or lexical sequences (acoustic-phonetic decoding) or from acoustic or lexical sequences to query strings (for database access) or (robot control) commands (semantic decoding) (Vidal, Casacuberta, and Garc´ıa 1995; Vidal 1997; Bangalore and Ricardi 2000a, 2000b; Hazen, Hetherington, and Park 2001; Mou, Seneff, and Zue 2001; Segarra et al.2001; Seward 2001).
N01-1018 W00-0508
related approach was proposed in Bangalore and Ricardi (2000b).
W00-0508
211 Casacuberta and Vidal Translation with Finite-State Transducers Different approaches for estimating Pr(t, a | s) were proposed in Brown et al.(1993). These approaches are known as models 1 through 5.
J93-2003
206 Computational Linguistics Volume 30, Number 2 Garc´ıa, and Vidal 1993; M¨akinen 1999; Knight and Al-Onaizan 1998; Bangalore and Ricardi 2000b; Casacuberta 2000; Vilar 2000).
W00-0508
1. Introduction Formal transducers give rise to an important framework in syntactic-pattern recognition (Fu 1982; Vidal, Casacuberta, and Garc´ıa 1995) and in language processing (Mohri 1997).
J97-2003
Adequate software packages are publicly available for training these statistical models and for obtaining good alignments between pairs of sentences (Al-Onaizan et al.1999; Och and Ney 2000).
P00-1056
These results were achieved using the statistical alignments provided by model 5 (Brown et al.1993; Och and Ney 2000) and smoothed 11-grams and 6-grams, respectively.
J93-2003 P00-1056
In the following section we show how this drawback can be overcome using statistical alignments (Brown et al.1993). The resulting methodology is called grammatical inference and alignments for transducer inference (GIATI).
J93-2003
In this respect, the bilingual word reordering ideas of Vilar, Vidal, and Amengual (1996), Vidal (1997), and Bangalore and Ricardi (2000a) may certainly prove useful in future developments.
W00-0508
Alignments The statistical translation models introduced by Brown et al.(1993) are based on the concept of alignment between source and target words (statistical alignment models).
J93-2003
GIATI outperforms other finite-state techniques in similar experimental conditions (with a best result of 8.3% WER, using another transducer inference technique called OMEGA [ITI et al.2000]). On the other hand, the best result achieved by the statistical templates technique (Och and Ney 2000) was 4.4% WER (ITI et al.2000). However, this result cannot be exactly compared with that achieved by GIATI, because the statistical templates approach used an explicit (automatic) categorization of the source and the target words, while only the raw word forms were used in GIATI.
P00-1056
(Mohri 1997; Vidal 1997; Bangalore and Ricardi 2000b, 2001; Amengual et al.2000). Rational transductions (Berstel 1979) constitute an important class within the field of formal translation.
J97-2003 N01-1018 W00-0508
