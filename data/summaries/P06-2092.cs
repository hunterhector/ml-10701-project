Another approach to word alignment is presented by Tiedemann (2003), where alignment probabilities are computed using a combination of features like e.g. co-occurrence, cognateness, syntactic category membership.
E03-1026
Aligning parallel text, i.e. automatically setting the sentences or words in one text into correspondence with their equivalents in a translation, is a very useful preprocessing step for a range of applications, including but not limited to machine translation (Brown et al., 1993), cross-language information retrieval (Hiemstra, 1996), dictionary creation (Smadja et al., 1996) and induction of NLP-tools (Kuhn, 2004).
J93-2003 J96-1001
Alignment Sentence alignment strategies fall roughly into three categories: length-based approaches (Gale and Church, 1991; Gale and Church, 1993) are based on the assumption that the length proportions of a sentence and its translation are roughly the same.
J93-1004 P91-1023
Order Differences Another problem that has been noticed as early as 1993 with the first research on word alignment (Brown et al., 1993) concerns the differences in word order between source and target language.
J93-2003
The third approach uses bilingual lexical information, e.g. estimated from the corpus (Kay and R¨oscheisen, 1993; Fung and Church, 1994; Fung and McKeown, 1994).
C94-2178 J93-1006
Other word alignment strategies (Toutanova et al., 2002; Cherry and Lin, 2003) have also begun to incorporate linguistic knowledge.
P03-1012 W02-1012
While simple statistical alignment models like IBM-1 (Brown et al., 1993) and the symmetric alignment approach by Hiemstra (1996) treat sentences as unstructured bags of words, the more sophisticated IBM-models by Brown et al.(1993) approximates word order differences using a statistical distortion factor.
J93-2003
Alignment Aligning below the sentence level is usually done using statistical models for machine translation (Brown et al., 1991; Brown et al., 1993; Hiemstra, 1996; Vogel et al., 1999) where any word of the targetlanguageistakentobeapossibletranslation for each source language word.
J93-2003 P91-1022
Recently, researchers like Cherry and Lin (2003) have begun to use syntactic analyses to guide and restrict the word alignment process.
P03-1012
We have decided to use the evaluation metrics precision, recall and the alignment error rate (AER) proposed by Och and Ney (2000) in order to compare results to those of other alignment systems.
P00-1056
The alignment of sentences can be done sufficiently well using cues such as sentence length (Gale and Church, 1993) or cognates (Simard et al., 1992).
J93-1004
Wordalignment, however, isalmost exclusively done using statistics (Brown et al., 1993; Hiemstra, 1996; Vogel et al., 1999; Toutanova et al., 2002).
J93-2003 W02-1012
alignment Like syntactic differences, n:m correspondences, i.e. alignments that involve multiword expressions, have soon been noted as being difficult for statistical word alignment: Brown et al.(1993) modelled fertility, as they called it, statistically in the more sophisticated IBM-models.
J93-2003
