Similarly, if the task is to distinguish between binary, coarse sense distinction, then current WSD techniques can achieve very high accuracy (in excess of 96% when tested on a dozen words in (Yarowsky, 1995)).
P95-1026
In Section 3, I examine the size of the training corpus on the accuracy of WSD, using a corpus of 192,800 occurrences of 191 words hand tagged with WORDNET senses (Ng and Lee, 1996).
P96-1006
investigate the effect of the number of training examples on WSD accuracy, I ran the exemplarbased WSD algorithm L~.XAS on varying number of training examples to obtain learning curves for the 191 words (details of LEXAS are described in (Ng and Lee, 1996)).
P96-1006
This is also the task addressed by other WSD research such as (Bruce and Wiebe, 1994; Miller et al., 1994).
H94-1046 P94-1020
The two test sets, BC50 and WSJ6, are the same as those reported in (Ng and Lee, 1996).
P96-1006
Similarly, (Yarowsky, 1995) tested his WSD algorithm on a dozen words.
P95-1026
The performance figures of LEXAS in Table 1 are higher than those reported in (Ng and Lee, 1996).
P96-1006
However, as reported in (Miller et al., 1994), there are not enough training examples per word in SP.MCOR to yield a broad coverage, high accuracy WSD program, due to the fact that sense tagging is done on every word in a running text in SEMCOR.
H94-1046
For example, in (Engelson and Dagan, 1996), POS top 80% noun 5.14 verb 8.75 adj 5.87 adv 4.22 top 90% 4.48 6.89 4.75 3.79 top 95% 4.07 5.77 4.08 3.48 top 99% 3.51 4.53 3.47 2.96 bottom 20% bottom I0% 2.86 2.71 3.43 3.15 2.86 2.72 2.55 2.46 bottom 5% bottom 1% 2.59 2.44 2.94 2.67 2.63 2.44 2.38 2.31 Table 4: Average number of senses per polysemous word in the Brown corpus for the top 80%, ..., top 99%, and the bottom 20%, ..., bottom 1% of word occurrences.
P96-1042
Much recent research in the field of natural language processing (NLP) has focused on an empirical, corpus-based approach (Church and Mercer, 1993).
J93-1001
Using the sense-tagged corpus of 192,800 word occurrences reported in (Ng and Lee, 1996), I examine the effect of the number of training examples on the accuracy of an exemplar-based classifier versus the base-line, most-frequent-sense classitier.
P96-1006
Mooney. 1996.
W96-0208
Sense Disambiguation in the Large In (Gale et al., 1992), it was argued that any wide coverage WSD program must be able to perform significantly better than the most-frequent-sense classifier to be worthy of serious consideration.
P92-1032
The high accuracy achieved by a corpus-based approach to part-of-speech tagging and noun phrase parsing, as demonstrated by (Church, 1988), has inspired similar approaches to other problems in natural language processing, including syntactic parsing and word sense disambiguation (WSD).
A88-1019
The availability of large quantities of part-ofspeech tagged and syntactically parsed sentences like the Penn Treebank corpus (Marcus, Santorini, and Marcinkiewicz, 1993) has contributed greatly to the development of robust, broad coverage partof-speech taggers and syntactic parsers.
J93-2004
To overcome this data sparseness problem of WSD, I initiated a mini-project in sense tagging and collected a corpus in which 192,800 occurrences of 191 words have been manually tagged with senses of WORDNET (Ng and Lee, 1996).
P96-1006
When the task is to resolve word senses to the fine-grain distinction of WORDNET senses, the accuracy figures achieved are generally not very high (Miller et al., 1994; Ng and Lee, 1996).
H94-1046 P96-1006
This is in contrast to disambiguating word senses to the refined senses of WoRDNET, where for instance, the average number of senses per noun is 7.8 and the average number of senses per verb is 12.0 for the set of 191 most ambiguous words investigated in (Ng and Lee, 1996).
P96-1006
The work of (Dagan and Itai, 1994) has also successfully used WSD to improve the accuracy of machine translation.
J94-4003
The sense-tagged corpus SEMCOI~, prepared by (Miller et al., 1994), contains a substantial subset of the Brown corpus tagged with the refined senses of WORDNET.
H94-1046
Effect of Training Corpus Size A number of past research work on WSD, such as (Leacock et al., 1993; Bruce and Wiebe, 1994; Mooney, 1996), were tested on a small number of words like "line" and "interest".
H93-1051 P94-1020 W96-0208
