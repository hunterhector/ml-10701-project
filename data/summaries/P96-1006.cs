This should not be too surprising, as it is widely believed that sense tagging using the full set of refined senses found in a large dictionary like WORDNET involve making subtle human judgments (Wilks et al., 1990; Bruce and Wiebe, 1994), such that there are many genuine cases where two humans will not agree fully on the best sense assignments.
P94-1020
One exception is the sense-tagged data set used in (Bruce and Wiebe, 1994), which has been made available in the public domain by Bruce and Wiebe.
P94-1020
One line of research focuses on the use of the knowledge contained in a machine-readable dictionary to perform WSD, such as (Wilks et al., 1990; Luk, 1995).
P95-1025
Although the work of (Yarowsky, i994) can be applied to WSD, the results reported in (Yarowsky, 1994) only dealt with accent restoration, which is a much simpler problem.
P94-1013
We also include verb-object syntactic relation as a feature, which is not used in (Yarowsky, 1994).
P94-1013
The work of (McRoy, 1992) pointed out that a diverse set of knowledge sources are important to achieve WSD, but no quantitative evaluation was given on the relative importance of each knowledge source.
J92-1001
Making such an assumption is reasonable since POS taggers that can achieve accuracy of 96% are readily available to assign POS to unrestricted English sentences (Brill, 1992; Cutting et al., 1992).
A92-1018 A92-1021
Bruce and Wiebe also performed a separate test by using a subset of the "interest" data set with only 4 senses (sense 1, 4, 5, and 6), so as to compare their results with previous work on WSD (Black, 1988; Zernik, 1990; Yarowsky, 1992), which were tested on 4 senses of the noun "interest".
C92-2070
That local collocation knowledge provides important clues to WSD is pointed out in (Yarowsky, 1993), although it was demonstrated only on performing binary (or very coarse) sense disambiguation.
H93-1052
To evaluate the performance of LEXAS, we conducted two tests, one on a common data set used in (Bruce and Wiebe, 1994), and another on a larger data set that we separately collected.
P94-1020
A probabilistic classifier is used in (Bruce and Wiebe, 1994).
P94-1020
Luk. 1995.
P95-1025
To get an idea of how the sense assignments of our data set compare with those provided by WoRDNET linguists in SEMCOR, the sense-tagged subset of Brown corpus prepared by Miller et al.(Miller et al., 1994), we compare 44 Test set BC50 WSJ6 Sense 1 40.5% 44.8% Most Frequent LEXAS 47.1% 54.0% 63.7% 68.6% Table 5: Evaluation on a Large Data Set a subset of the occurrences that overlap.
H94-1046
This default strategy has been advocated as the baseline performance level for comparison with WSD programs (Gale et al., 1992).
P92-1032
The work of (Miller et al., 1994) is the only prior work we know of which attempted to evaluate WSD on a large data set and using the refined sense distinction of WORDNET.
H94-1046
In each of our 100 random trials, the accuracy of LEXAS is always higher than the accuracy of 78% reported in (Bruce and Wiebe, 1994).
P94-1020
In contrast, LEXAS uses supervised learning from tagged sentences, which is also the approach taken by most recent work on WSD, including (Bruce and Wiebe, 1994; Miller et al., 1994; Leacock et al., 1993; Yarowsky, 1994; Yarowsky, 1993; Yarowsky, 1992).
C92-2070 H93-1051 H93-1052 H94-1046 P94-1013 P94-1020
The work of (Miller et al., 1994; Leacock et al., 1993; Yarowsky, 1992) used only the unordered set of surrounding words to perform WSD, and they used statistical classifiers, neural networks, or IR-based techniques.
C92-2070 H93-1051 H94-1046
To evaluate our WSD program, named LEXAS (LEXical Ambiguity-resolving _System), we tested it on a common data set involving the noun "interest" used by Bruce and Wiebe (Bruce and Wiebe, 1994).
P94-1020
LEXAS achieves a mean accuracy of 87.4% on this data set, which is higher than the accuracy of 78% reported in (Bruce and Wiebe, 1994).
P94-1020
Most recently, Yarowsky used an unsupervised learning procedure to perform WSD (Yarowsky, 1995), although this is only tested on disambiguating words into binary, coarse sense distinction.
P95-1026
The work of (Bruce and Wiebe, 1994) used parts of speech (POS) and morphological form, in addition to surrounding words.
P94-1020
In the results reported in (Bruce and Wiebe, 1994), they used a test set of 600 randomly selected sentences from the 2369 sentences.
P94-1020
In order to evaluate the relative contribution of the knowledge sources, including (1) POS and mor43 WSD research Accuracy Black (1988) 72% Zernik (1990) 70% Yarowsky (1992) 72% Bruce & Wiebe (1994) 79% LEXhS (1996) 89% Table 3: Comparison with previous results Knowledge Source POS & morpho surrounding words collocations verb-object Mean Accuracy 77.2% 62.0% 80.2% 43.5% Std Dev 1.44% 1.82% 1.55% 1.79% Table 4: Relative Contribution of Knowledge Sources phological form; (2) unordered set of surrounding words; (3) local collocations; and (4) verb to the left (verb-object syntactic relation), we conducted 4 separate runs of 100 random trials each.
C92-2070 P94-1013 P94-1020
Previous work on using the unordered set of surrounding words have used a much larger window, such as the 100-word window of (Yarowsky, 1992), and the 2-sentence context of (Leacock et al., 1993).
C92-2070 H93-1051 H93-1052
However, the work of (Black, 1988; Zernik, 1990; Yarowsky, 1992) were not based on the present set of sentences, so the comparison is only suggestive.
C92-2070
McRoy 1992.
J92-1001
The work of (Yarowsky, 1994) is perhaps the most similar to our present work.
P94-1013
