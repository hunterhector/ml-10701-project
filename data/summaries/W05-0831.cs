Criteria For the automatic evaluation, we used the criteria from the IWSLT evaluation campaign (Akiba et al., 2004), namely word error rate (WER), positionindependent word error rate (PER), and the BLEU and NIST scores (Papineni et al., 2002; Doddington, 2002).
P02-1040
Zens et al.(2003) reviewed two types of reordering constraints for this type of translation systems.
P03-1019
Mapping the bilingual language model to a WFST T is canonical and it has been shown in (Kanthak et al., 2004) that the search problem can then be rewritten using finite-state terminology: ˆeI1 = project-output(best(fJ1 ◦ T)).
P04-1065
Constraints Another type of reordering can be obtained using Inversion Transduction Grammars (ITG) (Wu, 1997).
J97-3002
Permutation Automata For on-demand computation of an automaton in the flavor described in (Kanthak et al., 2004) it is sufficient to specify a state description and an algorithm that calculates all outgoing arcs of a state from the state description.
P04-1065
In a refinement with additional phrase-based models, (Kumar et al., 2003) define a probability distribution over all possible permutations of source sentence phrases and prune the resulting automaton to reduce complexity.
N03-1019
In (Bangalore et al., 2000) weighted reordering has been applied to target sentences since defining a permutation model on the source side is impractical in combination with speech recognition.
W00-0508
g. the GIATI method of (Casacuberta et al., 2004), or with our novel monotonization technique (see Sec.
J04-2004
The general GIATI technique (Casacuberta et al., 2004) is applicable and can be used to monotonize the alignment A2.
J04-2004
Following (Matusov et al., 2004), we compute these local costs by interpolating state occupation probabilities from the source-to-target and target-to-source training of the HMM and IBM-4 models as trained by the GIZA++ toolkit (Och et al., 2003).
C04-1032 J03-1002
The automated transducer inference techniques OMEGA (Vilar, 2000) and GIATI (Casacuberta et al., 2004) work on phrase level, but ignore the reordering problem from the view of the model.
J04-2004
Wu. 1997.
J97-3002
