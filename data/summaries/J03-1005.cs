Translation approaches that use the IBM-2 model parameters but are based on DP are presented in Garc´ıa-Varea, Casacuberta, and Ney (1998) and Niessen et al.(1998). An approach based on the hidden Markov model alignments as used in speech recognition is presented in Tillmann, Vogel, Ney, and Zubiaga (1997) and Tillmann, Vogel, Ney, Zubiaga, and Sawaf (1997).
P97-1037
To fully exploit the speedup of the DP beam search, the search space is dynamically constructed as described in Tillmann, Vogel, Ney, Zubiaga, and Sawaf (1997), rather than using a static search space.
P97-1037
Word joining: Target language words are joined using a method similar to the one described in Och, Tillmann, and Ney (1999).
W99-0604
Wang and Waibel (1997) presents a search algorithm for the IBM-2 translation model based on the A ∗ concept and multiple stacks.
P97-1047
The resulting bilingual data have been sentence-aligned using statistical methods (Brown et al.1990). Originally, about three million sentences were selected.
J90-2002
For placing the “head” the center function center(i) (Brown et al.[1993] uses the notation circledot i ) is used: the average position of the source words with which the target word e i−1 is aligned.
J93-2003
Among all possible target strings, we will choose the string with the highest probability as given by Bayes’ 1 The word reordering restriction used in the search procedure described in Berger et al.(1996) is not mentioned in Brown et al.(1993), although exactly the translation model described there is used.
J93-2003
A preliminary version of the work presented here was published in Tillmann and Ney (2000).
C00-2123
The search algorithm uses the translation model presented in Brown et al.(1993). Starting from a DP-based solution to the traveling-salesman problem, we present a novel technique to restrict the possible word reorderings between source and target language in order to achieve an efficient search algorithm.
J93-2003
Here, we will use a trigram language model and the translation model presented in Brown et al.(1993). Since the number of possible translations of a given source sentence is enormous, we must find the best output without actually generating the set of all possible translations; instead we would like to focus on the most likely translation hypotheses during the search process.
J93-2003
Some of the experiments on the Canadian Hansards task have been carried out by Nicola Ueffing using the existing implementation of the search algorithm (Och, Ueffing, and Ney [2001]).
W01-1408
In Brown et al.(1993), two types of distortion probabilities are distinguished: (1) the leftmost word of a set of source words f aligned to the same target word e (which is called the “head”) is placed, and (2) the remaining source words are placed.
J93-2003
Berger et al.(1994) describes the French-to-English Candide translation system, which uses the translation model proposed in Brown et al.(1993). A detailed description of the decoder used in that system is given in Berger et al.(1996) but has never been published in a paper: Throughout the search process, partial hypotheses are maintained in a set of priority queues.
H94-1028 J93-2003
Three different decoders for the IBM-4 translation model are compared in Germann et al.(2001). The first is a reimplementation of the stack-based decoder described in Berger et al.(1996). The second is a greedy decoder that starts with an approximate solution and then iteratively improves this first rough solution.
P01-1030
The fertility for the “null” word is treated specially (for details see Brown et al.[1993]). Berger et al.(1996) describes the extension of a partial hypothesis by a pair of target words (e prime, e), where e prime is not connected to any source word f . In this case, the so-called spontaneous target word e prime is accounted for with the fertility.
J93-2003
On the other hand, since the decoding problem for the IBM-4 translation model is provably NP-complete, as shown in Knight (1999) and Germann et al.(2001), word reordering restrictions as introduced in this article are essential for obtaining an efficient search algorithm that guarantees that a solution close to the optimal one will be found.
J99-4005 P01-1030
3. Beam Search in Statistical Machine Translation 3.1 Inverted Alignment Concept To explicitly describe the word order difference between source and target language, Brown et al.(1993) introduced an alignment concept, in which a source position j is mapped to exactly one target position i: regular alignment: j → i = a j 102 Computational Linguistics Volume 29, Number 1 e . In this case my colleague can k not visit on the fourth of May mK S you avMn c h t bF e s u c h e n . n d e a n n o e g e ee n ia i I i ii m e s i r t e l ll l am n Figure 2 Regular alignment example for the translation direction German to English.
J93-2003
Tillmann, Vogel, Ney, and Zubiaga (1997) proposes a dynamic programming (DP)–based search algorithm for statistical MT that monotonically translates the input sentence from left to right.
P97-1037
The work by Wu (1996) also uses the original IBM model parameters and obtains an efficient search algorithm by restricting the possible word reorderings using the so-called stochastic bracketing transduction grammar.
P96-1021
The actual implementation used during the experiments is described in AlOnaizan et al.(1999) and in Och and Ney (2000).
C00-2163
2. Previous Work 2.1 IBM Translation Approach In this article, we use the translation model presented in Brown et al.(1993), and the mathematical notation we use here is taken from that paper as well: a source string f J 1 = f 1 ···f j ···f J is to be translated into a target string e I 1 = e 1 ···e i ···e I. Here, I is the length of the target string, and J is the length of the source string.
J93-2003
In Brown et al.(1993), this alignment concept is used for model IBM-1 through model IBM-5.
J93-2003
Another approach for mapping a single source language word to several target language words involves preprocessing by the word-joining algorithm given in Tillmann (2001), which is similar to the approach presented in Och, Tillmann, and Ney (1999).
W99-0604
The implementation details for using the full set of IBM-4 model parameters are given in Section 3.9.2. 101 Tillmann and Ney DP Beam Search for Statistical MT 2.2 Search Algorithms for Statistical Machine Translation In this section, we give a short overview of search procedures used in statistical MT: Brown et al.(1990) and Brown et al.(1993) describe a statistical MT system that is based on the same statistical principles as those used in most speech recognition systems (Jelinek 1976).
J90-2002 J93-2003
Since the efficiency of the beam search approach is based on restrictions on the allowed coverage vectors C alone, the approach may be used for different types of translation models as well (e.g., for the multiword-based translation model proposed in Och, Tillmann, and Ney [1999]).
W99-0604
The classes are automatically trained (Brown et al.1992). When the IBM-4 model parameters are used during search, an input sentence can be processed one source position at a time in a certain order primarily determined by the distortion probabilities.
J92-4003
Equivalently, we use exactly the translation model described in Brown et al.(1993) but try different reordering restrictions for the DP-based search procedure.
J93-2003
