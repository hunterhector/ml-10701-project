Here we followed the suggestion that the unknown words actually are quite similar to words that occur only once (hapax words) in the corpus (Dermatas and Kokkinakis 1995; Baayen and Sproat 1995).
J95-2001
In Brill (1994, 1995) a transformation-based learner that learns guessing rules from a pretagged training corpus is outlined: First the unknown words are labeled as common nouns and a list of generic transformations is defined.
J95-4004
Brill (1994, 1995) describes a system of rules that uses both ending-guessing and more morphologically motivated rules.
J95-4004
A rule-based tagger described in Voutilainen (1995) was equipped with a set of guessing rules that had been hand-crafted using knowledge of English morphology and intuitions.
E95-1022
The ending-guessing approach was elaborated in Weischedel et al.(1993), where an unknown word was guessed by using the probability for an unknown word to be of a particular Pos-tag, given its capitalization feature and its ending.
J93-2006
Zhang and Kim (1990) developed a system for automated learning of morphological word formation rules.
C90-2074
When we removed from the lexicon all the hapax words and, following the recommendation of Church (1988), all the capitalized words with frequency less than 20, we obtained some 51,522 unknown word-tokens (25,359 wordtypes) out of more than a million word-tokens in the Brown Corpus.
A88-1019
This agrees with the results on the closed dictionary (i.e., without unknown words) obtained by other researchers for this class of the model on the same corpus (Kupiec 1992; DeRose 1988).
J88-1003
Such methods can achieve better performance, reaching tagging accuracy of up to 85% on unknown words for English (Brill 1994; Weischedel et al.1993). The Xerox tagger (Cutting et al.1992) comes with a set of rules that assign an unknown word a set of possible pos-tags (i.e., POS-class) on the basis of its ending segment.
A92-1018 J93-2006
As the baseline standard, we took the ending-guessing rule set supplied with the Xerox tagger (Cutting et al.1992). When we compared the Xerox ending guesser with the induced ending-guessing rule set (Ending*), we saw that its precision was about 6% poorer and, most importantly, it 416 Andrei Mikheev Unknown-Word Guessing could handle 6% fewer unknown words.
A92-1018
A statistical-based suffix learner is presented in Schmid (1994).
C94-1027
The proposed guessing-rule schemata is in fact quite similar to the set of generic transformations for unknown-word guessing developed by Brill (1995).
J95-4004
It has been noticed (as in \[Weischedel et al., 1993\], for example) that capitalized and hyphenated words have a different distribution from other words.
J93-2006
In this evaluation we used the cascading guesser with two different taggers: a c++ implemented bigram HMM tagger akin to one described in Kupiec (1992) and the rule-based tagger of Brill (1995).
J95-4004
As argued in Church (1988), who proposes a more elaborated heuristic, Dermatas and Kokkinakis (1995) proposed a simple probabilistic approach to unknown-word guessing: HCRC, Language Technology Group, University of Edinburgh, 2 Buccleuch Place, Edinburgh EH8 9LW, Scotland, UK.
A88-1019 J95-2001
We constructed an English lexicon of 72,136 word forms with morphological features, which we then mapped into the Penn Treebank tag set (Marcus, Marcinkiewicz, and Santorini 1993).
J93-2004
This technique has been partially outlined in (Mikheev 1996a, 1996b) and, along with a level of accuracy for the induced rules that is higher than any previously quoted, it has an advantage in terms of quantity and simplicity of annotation of data for training.
C96-2130 P96-1043
We believe that the technique for the induction of the ending-guessing rules is quite similar to that of Xerox 1° or Schmid (1994) but differs in the scoring and pruning methods.
C94-1027
