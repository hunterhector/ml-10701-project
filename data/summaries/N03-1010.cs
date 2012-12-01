Using the same evaluation metric (but different evaluation data), Wang and Waibel (1997) report search error rates of 7.9% and 9.3%, respectively, for their decoders.
P97-1047
While acceptably fast for the kind of evaluation used in Germann et al.(2001), namely sentences of up to 20 words, its speed becomes an issue for more realistic applications.
P01-1030
Och et al.(2001) and Germann et al.(2001) both implemented optimal decoders and benchmarked approximative algorithms against them.
P01-1030 W01-1408
In this paper, we have analyzed the complexity of the greedy decoding algorithm originally presented in Germann et al.(2001) and presented improvements that drastically reduce the decoder’s complexity and speed to practically linear time.
P01-1030
distance (MSD) and the maximum swap segment size (MSSS) ranging from 0 to 10 and evaluated the translations with the BLEU7 metric (Papineni et al., 2002).
P02-1040
Germann et al.(2001) compare translations obtained by a multi-stack decoder and a greedy hill-climbing algorithm against those produced by an optimal integer programming decoder that treats decoding as a variant of the traveling-salesman problem (cf.
P01-1030
Tillmann and Ney, 2000; Berger et al., 1994; Alshawi et al., 2000; Vidal, 1997) impose limits on word reordering.
C00-2123 H94-1028 J00-1004
Och et al.report word error rates of 68.68% for optimal search (based on a variant of the A* algorithm), and 69.65% for the most restricted version of a decoder that combines dynamic programming with a beam search (Tillmann and Ney, 2000).
C00-2123
IBM Translation Models Brown et al.(1993) and Berger et al.(1994, 1996) view the problem of translation as that of decoding a message that has been distorted in a noisy channel.
H94-1028 J93-2003
The product of the translation model probability and the language model probability of a31 is called the alignment probability of a28 . Detailed formulas for the calculation of alignment probabilities according to the various models can be found in Brown et al.(1993). It should be noted here that the calculation of the alignment probability of an entire alignment (a31a69a68a24a70a72a71a12a73a75a74a24a70 ) has linear complexity.
J93-2003
Knight, 1999).
J99-4005
Most of the current work in statistical machine translation builds on word replacement models developed at IBM in the early 1990s (Brown et al., 1990, 1993; Berger et al., 1994, 1996).
H94-1028 J90-2002 J93-2003
For example, Berger et al.(1994), attribute only 5% of the translation errors of their Candide system, which uses 1Technically, the complexity is still a14a16a15a18a17a20a19a22a21 . However, the quadratic component has such a small coefficient that it does not have any noticable effect on the translation speed for all reasonable inputs.
H94-1028
In this subsection we recapitulate the greedy hillclimbing algorithm presented in Germann et al.(2001). In contrast to all other decoders mentioned in Sec.
P01-1030
Based on the conventions established in Brown et al.(1993), these models are commonly referred to as the (IBM) Models 1-5.
J93-2003
One of the big challenges in building actual MT systems within this framework is that of decoding: finding the translation candidate a9 that maximizes the translation probability a10 a1 a9a12a11 a13 a7 for the given input a13. Knight (1999) has shown the problem to be NP-complete.
J99-4005
For a different approach that is based on dependency tree transformations, see Alshawi et al.(2000). Thirdly, the results of our experiments with randomized searches show that greedy decoding does not perform as well on longer sentences as one might conclude from the findings in Germann et al.(2001). At the same time, the speed improvements presented in this paper make multiple searches feasible, allowing for an overall faster and better decoder.
J00-1004 P01-1030
