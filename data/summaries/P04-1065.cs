Srinivas Bangalore and Giuseppe Riccardi, 2000, Stochastic Finite-State models for Spoken Language Machine Translation, In Proc.
W00-0508
So, given an appropriate alignment which can be obtained by means of the pubically available GIZA++ toolkit (Och and Ney, 2000), the approach is very easy in practice: 1.
P00-1056
The search algorithms best and n-best are based on (Mohri and Riley, 2002), push is based on (Mohri and Riley, 2001) and failure mainly uses ideas from (Allauzen et al., 2003).
P03-1006
2 Finite-State Automata 2.1 Weighted Finite-State Transducer The basic theory of weighted finite-state automata has been reviewed in numerous papers (Mohri, 1997; Allauzen et al., 2003).
J97-2003 P03-1006
For example transducer determinization (Mohri, 1997) uses a set of pairs of states and weights.
J97-2003
For example, the current implementation of determinization is not as general as described in (Allauzen and Mohri, 2003).
P03-1006
Och and Hermann Ney, 2000, Improved Statistical Alignment Models, In Proc.
P00-1056
This segmentation can be directly calculated from the alignments A: Then we can formulate the problem of finding the best translation ˆeI1 of a source sentence as follows: ˆeI1 = argmax eI1 Pr(fJ1 ;eI1) … argmax A;epJp1 Pr(fJ1 ;epJp1) = argmax A;epJp1 Y fj:j=1::J Pr(fj;epjjfj¡11 ;epj¡1p1 ) … argmax A;epJp1 Y fj:j=1::J Pr(fj;epjjfj¡1j¡n;epj¡1pj¡n) The last line suggests to solve the translation problem by estimating a language model on a bilanguage (see also (Bangalore and Riccardi, 2000; Casacuberta et al., 2001)).
W00-0508
Among the most recent ones are full and lazy compilation of the search network for speech recognition (Mohri et al., 2000a), integrated speech translation (Vidal, 1997; Bangalore and Riccardi, 2000), speech summarization (Hori et al., 2003), language modelling (Allauzen et al., 2003) and parameter estimation through EM (Eisner, 2001) to mention only a few.
J97-2003 P03-1006 W00-0508
Cyril Allauzen, Mehryar Mohri, and Brian Roark, 2003, Generalized Algorithms for Constructing Statistical Language Models, In Proc.
P03-1006
Cyril Allauzen and Mehryar Mohri, 2003, Generalized Optimization Algorithm for Speech Recognition Transducers, In Proc.
P03-1006
Mehryar Mohri, 1997, Finite-State Transducers in Language and Speech Processing, Computational Linguistics, 23:2, 1997.
J97-2003
Task System Translation WER PER 100-BLEU Memory Time/Sentence [%] [%] [MB] [ms] Eutrans FSA Spanish ! English 8.12 7.64 10.7 6-8 20 AT 8.25 FUB FSA Italian ! English 27.0 21.5 37.7 3-5 22 AT 23.7 18.1 36.0 Verbmobil FSA German ! English 48.3 41.6 69.8 65-90 460 AT 40.5 30.1 62.2 PF-Star FSA Italian ! English 39.8 34.1 58.4 12-15 35 AT 36.8 29.1 54.3 e0 = project-output(best(f –T)) Translation results using this approach are summarized in Table 4 and are being compared with results obtained using the alignment template approach (Och and Ney, 2000).
P00-1056
The implementations of compose (Pereira and Riley, 1996), determinize (Mohri, 1997), minimize (Mohri, 1997) and remove-epsilons (Mohri, 2001) use more refined methods to gain efficiency.
J97-2003
