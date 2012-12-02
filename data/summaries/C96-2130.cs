Using the technique described above and the lexicon derived frora the Brown Corpus we extracted prefix morphological rules (no alterations), suffix morphological rules without alterations and ending guessing rules, exactly as it was done in (Mikheev, 1996).
P96-1043
A statistical-based suffix learnex is presented in (Schmid, 1994).
C94-1027
Mikheev 1996.
P96-1043
As it was measured in (Mikheev, 1996) simple concatenative prefix and sutlix morphological rules iInproved the overall i)recision of the cascading guesser 1)y about 5%, which resulted in 2% higher a(:curacy of tagging on mlknown words.
P96-1043
we calculate its score as explained in (Mikheev, 1996) using the scoring function as follows: .~/t 1 scorei =/3i 1.65 * V '~, t~ + log(ISd)) where /3 is the proportion of all positive outcomes (x) of the rule application to the total number of compatible to the rule words (n), and ISl is the length of the affix.
P96-1043
In (Mikheev, 1996), a technique for fully unsupervised statistical acquisition of rules which guess possible parts-ofspeech for unknown words was proposed.
P96-1043
\[t. Schmid 1994.
C94-1027
In this evaluation we used the cascading application of prefix rules, suffix rules and ending-guessing rules as described in (Mikheev, 1996).
P96-1043
In the rest of the paper first, we will I)riefly outline the unsupervised statistical learning technique proposed in (Mikheev, 1996), then we propose a modification which will allow for the incorporation of the learning of non-concatenative mort)hological rules, and finally, wc will ewfluate and assess the contribution of the non-concatenative sutfix morphological rules to the overall tagging av, curaey on unknown words using the cascading guesser.
P96-1043
In (Brill, 1995) a system of rules which uses both ending-guessing and more morphologically motivated rules is described.
J95-4004
in (Weischedel et al., 1993) where an unknown word was guessed given the probabilities for an unknown word to be of a particular pos, its capitalisation feature and its ending.
J93-2006
The learning technique employed in the induction of tile rules of the cascading guesser (Mikheev, 1996) does not require specially prepared training data and employs fully tmsupervised statistical learning from the lexicon supplied with the tagger and word-ti'equeneies obtained from a raw corpus.
P96-1043
Extraction Phase In the initial learning technique (Mikheev, 1996) which ac(:ounted only tbr sitnl)le concatenative regularities a guessing rule was seen as a triph',: A = (S, I, H,) where S is the affix itself; I is the l'os-elass of words which should be looked llI) in the lexicon as main forms; R is the pos-elass which is assigned to unknown words if the rule is satisfied.
P96-1043
Brill 1995.
J95-4004
Brill (Brill, 1995) outlines a transformation-based learner which learns guessing rules from a pretagged training corpus.
J95-4004
In (Mikheev, 1996) a cascading word-Pos guesser is described.
P96-1043
4shorter than 5 characters 774 5 Discussion and Conclusion The target; of the research reI)orted in this pa1)er was to incorporate the learning of morl)hological word-t'os guessing rules which (lo not ol)ey simI)le (:oncatenations of main words with affixes into the learning paradigm proposed in (Mikheev, 1996).
P96-1043
(Brill, 1995; Weischedel et al., 1993).
J93-2006 J95-4004
