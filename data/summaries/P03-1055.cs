For example, supertagging (Joshi and Bangalore, 1994) also aims to do more meaningful syntactic pre-processing.
C94-1024
controlled NP-traces (NP–NP), we follow the standard technique of marking nodes dominating the empty element up to but not including the parent of the antecedent as defective (missing an argument) with a gap feature (Gazdar et al., 1985; Collins, 1997).1 Furthermore, to make antecedent co-indexation possible with many types of EEs, we generalize Collins’ approach by enriching the annotation of non-terminals with the type of the EE in question (eg.
P97-1003
Rec. F-score Here Here Here Johnson OVERALL 80.5% 66.0% 72.6% 68.0% NP–NP 71.2% 62.8% 66.8% 60.0% WH–NP 91.6% 71.9% 80.6% 80.0% PRO–NP 68.7% 70.4% 69.5% 50.0% COMP–SBAR 93.8% 78.6% 85.5% 88.0% UNIT 99.1% 92.5% 95.7% 92.0% WH–S 86.7% 83.9% 84.8% 87.0% WH–ADVP 67.1% 31.3% 42.7% 56.0% CLAUSE 80.4% 68.3% 73.8% 70.0% COMP–WHNP 67.2% 38.8% 48.8% 47.0% Table 7: Antecedent recovery results for the combined NOINSERT model and comparison with Johnson (2002).
P02-1018
Furthermore, to ease straightforward comparison with previous work (Johnson, 2002), a new label CLAUSE is introduced for COMP-SBAR whenever it is followed by a moved clause WH–S.
P02-1018
Comparing our results to Johnson (2002), we find that the NOINSERT model outperforms that of Johnson by 4.6% (see Table 7).
P02-1018
Conditional parsing algorithms do exist, but they are difficult to train using large corpora (Johnson, 2001).
P01-1042
The other main difference is the apparently nonlocal nature of the problem, which motivates our choice of a Maximum Entropy (ME) model for the tagging task (Berger et al., 1996).
J96-1002
As our interest lies in trace detection and antecedent recovery, we adopt the evaluation measures introduced by Johnson (2002).
P02-1018
Johnson (2002) proposes an algorithm that is able to find long-distance dependencies, as a postprocessing step, after parsing.
P02-1018
We used the Wall Street Journal (WSJ) part of the Penn Treebank (Marcus et al., 1993), where extraction is represented by co-indexing an empty terminal element (henceforth EE) to its antecedent.
J93-2004
Templates for local features are similar to the ones employed by Ratnaparkhi (1996) for POS-tagging (Table 3), though as our input already includes POStags, we can make use of part-of-speech information as well.
W96-0213
However, such constructions prove to be difficult for stochastic parsers (Collins et al., 1999) and they either avoid tackling the problem (Charniak, 2000; Bod, 2003) or only deal with a subset of the problematic cases (Collins, 1997).
A00-2018 E03-1005 P97-1003 P99-1065
Rec. F-score Here Here Here Johnson LABELED 86.5% 72.9% 79.1% – UNLABELED 93.3% 78.6% 85.3% – NP–NP 87.8% 79.6% 83.5% – WH–NP 92.5% 75.6% 83.2% 81.0% PRO–NP 68.7% 70.4% 69.5% – COMP–SBAR 93.8% 78.6% 85.5% 88.0% UNIT 99.1% 92.5% 95.7% 92.0% WH–S 94.4% 91.3% 92.8% 87.0% WH–ADVP 81.6% 46.8% 59.5% 56.0% CLAUSE 80.4% 68.3% 73.8% 70.0% COMP–WHNP 67.2% 38.3% 48.8% 47.0% Table 5: EE-detection results on Section 23 and comparison with Johnson (2002) (where applicable).
P02-1018
We determine weights for the features with a modified version of the Generative Iterative Scaling algorithm (Curran and Clark, 2003).
E03-1071
Dienes and Dubey (2003)).
W03-1005
Table 1 summarizes the most frequent types occurring in the development data, Section 0 of the WSJ corpus, and gives an example for each, following Johnson (2002).
P02-1018
Work Excluding Johnson (2002)’s pattern-matching algorithm, most recent work on finding head– dependencies with statistical parser has used statistical versions of deep grammar formalisms, such as CCG (Clark et al., 2002) or LFG (Riezler et al., 2002).
P02-1018 P02-1035 P02-1042
First, we extend the mechanism of adding gap variables for nodes dominating a site of discontinuity (Collins, 1997).
P97-1003
The idea of threading EEs to their antecedents in a stochastic parser was proposed by Collins (1997), following the GPSG tradition (Gazdar et al., 1985).
P97-1003
In this section, we validate the two-step approach, by applying the parser to the output of the trace tagger, and comparing the antecedent recovery accuracy to Johnson (2002).
P02-1018
