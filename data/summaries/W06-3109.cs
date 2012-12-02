Additionally, certain translation systems, e.g. the Pharaoh decoder (Koehn, 2003) use an alternative 66 Figure 2: Flow chart associated to the expansion of a hypothesis when using a multi-stack algorithm.
N03-1017
(1). In the literature, we can find different techniques to deal with this problem, ranging from heuristic and fast (as greedy decoders) to optimal and very slow decoding algorithms (Germann et al., 2001).
P01-1030
The most widely used single-word-based statistical alignment models (SAMs) have been proposed in (Brown et al., 1993; Ney et al., 2000).
J93-2003
On the other hand, models that deal with structures or phrases instead of single words have also been proposed: the syntax translation models are described in (Yamada and Knight, 2001), alignment templates are used in (Och, 2002), and the alignment template approach is re-framed into the so-called phrase based translation (PBT) in (Marcu and Wong, 2002; Zens et al., 2002; Koehn et al., 2003; Tom´as and Casacuberta, 2003).
N03-1017 P01-1067 W02-1018
All these works follow two main different approaches according to the number of stacks used in the design and implementation of the search algorithm (the stacks are used to store partial hypotheses, sorted according to their partial score/probability, during the search process) : • On the one hand, in (Wang and Waibel, 1998; Och et al., 2001) a single stack is used.
W01-1408
• On the other hand (Berger et al., 1996; Germann et al., 2001) make use of multiple stacks 64 (one for each set of source covered/translated words in the partial hypothesis) in order to solve the disadvantages of the single-stack approach.
P01-1030
Many works (Berger et al., 1996; Wang and Waibel, 1998; Germann et al., 2001; Och et al., 2001; Ort´ız et al., 2003) have adopted different types of stack-based algorithms to solve the global search optimization problem for statistical machine translation.
P01-1030 W01-1408
