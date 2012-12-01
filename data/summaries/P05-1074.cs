We produced automatic alignments for it with the Giza++ toolkit (Och and Ney, 2003).
J03-1002
The original formulation of statistical machine translation (Brown et al., 1993) was defined as a word-based operation.
J93-2003
In the automatic evaluation of machine translation, paraphrases may help to alleviate problems presented by the fact that there are often alternative and equally valid ways of translating a text (Pang et al., 2003).
N03-1024
Our method for identifying paraphrases is an extension of recent work in phrase-based statistical machine translation (Koehn et al., 2003).
N03-1017
Koehn (2004), Tillmann (2003), and Vogel et al.(2003) describe various heuristics for extracting phrase alignments from the Viterbi word-level alignments that are estimated using Brown et al.(1993) models.
J93-2003 N03-1017 W03-1001
Work Barzilay and McKeown (2001) extract both singleand multiple-word paraphrases from a monolingual parallel corpus.
P01-1008
Och and Ney (2003) show that the accuracy of alignments produced by Giza++ improve as the size of the training corpus increases.
J03-1002
The results of our systems are not directly comparable, since Barzilay and McKeown (2001) evaluated their paraphrases with a different set of criteria (they asked judges whether to judge paraphrases based on “approximate conceptual equivalence”).
P01-1008
Examples of monolingual parallel corpora that have been used are multiple translations of classical French novels into English, and data created for machine translation evaluation methods such as Bleu (Papineni et al., 2002) which use multiple reference translations.
P02-1040
Since the best paraphrase may vary depending on information about the sentence that e1 appears in, we extend the paraphrase probability to include that sentence S: ˆe2 = arg max e2negationslash=e1 p(e2|e1,S) (4) word-level alignments in this paper, direct estimation of phrasal translations (Marcu and Wong, 2002) would also suffice for extracting paraphrases from bilingual corpora.
W02-1018
We use the heuristic for phrase alignment described in Och and Ney (2003) which aligns phrases by incrementally building longer phrases from words and phrases which have adjacent alignment points.1 1Note that while we induce the translations of phrases from 598 what is more, the relevant cost dynamic is completelyunder control im übrigen ist die diesbezügliche kostenentwicklung völlig unter kontrolle we owe it to the taxpayers to keep in checkthe costs wir sind es den steuerzahlern die kosten zu habenschuldig unter kontrolle Figure 2: Using a bilingual parallel corpus to extract paraphrases 2.2 Assigning probabilities We define a paraphrase probability p(e2|e1) in terms of the translation model probabilities p(f|e1), that the original English phrase e1 translates as a particular phrase f in the other language, and p(e2|f), that the candidate paraphrase e2 translates as the foreign language phrase.
J03-1002
Figure 1: Using a monolingal parallel corpus to extract paraphrases ing when multiple phrases map onto a single foreign language phrase is the converse of the assumption made in the word sense disambiguation work of Diab and Resnik (2002) which posits different word senses when a single English word maps onto different words in the foreign language (we return to this point in Section 4.4).
P02-1033
for word sense As mentioned in Section 1, the way that we extract paraphrases is the converse of the methodology employed in word sense disambiguation work that uses parallel corpora (Diab and Resnik, 2002).
P02-1033
Ibrahim et al.(2003) combine the two approaches: aligned monolingual corpora and parsing.
W03-1608
paraphrases Much previous work on extracting paraphrases (Barzilay and McKeown, 2001; Barzilay and Lee, 2003; Pang et al., 2003) has focused on finding identifying contexts within aligned monolingual sentences from which divergent text can be extracted, and treated as paraphrases.
N03-1003 N03-1024 P01-1008
Pang et al.(2003) use parse trees over sentences in monolingual parallel corpus to identify paraphrases by grouping similar syntactic constituents.
N03-1024
Barzilay and McKeown (2001) gives the example shown in Figure 1 of how identical surrounding substrings can be used to extract the paraphrases of burst into tears as cried and comfort as console.
P01-1008
Past work (Barzilay and McKeown, 2001; Barzilay and Lee, 2003; Pang et al., 2003; Ibrahim et al., 2003) has examined the use of monolingual parallel corpora for paraphrase extraction.
N03-1003 N03-1024 P01-1008 W03-1608
This means that our method will reap the benefits of research that improvements to automatic alignment techniques (Callison-Burch et al., 2004), and will further improve as more parallel data becomes available.
P04-1023
In question answering, discovering paraphrased answers may provide additional evidence that an answer is correct (Ibrahim et al., 2003).
W03-1608
