2Following (Poesio and Vieira, 1998), we use the term ‘anchor’ as as a generalization of the term ANTECEDENT, to indicate the discourse entity which an anaphoric expression either realizes, or is related to by an associative relation; reserving ‘antecedent’ for the cases of identity.
J98-2001
Subsequent work found, however, that restricting the type of bridging inferences required does make it possible for annotators to agree among themselves (Poesio et al., 2004).
J04-3003
Uryupina (2003) used the Web to estimate ‘Definiteness probabilities’ used as a feature to identify discourse-new definites.
P03-2012
The HAL model discussed in Lund et al.(1995) was used to find the anchor of the BDs in the dataset already used by Poesio et al.(1997). However, using vectorial representations did not improve the results for the ‘WordNet’ BDs: for the synonymy cases the results were comparable to those obtained with WordNet (4/12, 33%), but for the hyponymy BDs (2/14, as opposed to 8/14 with WordNet) and especially for mereological references (2/12) they were clearly worse.
W97-1301
Markert et al.(2003) used the Web and the construction method to extract information about hyponymy used to resolve other-anaphora (achieving an f value of around 67%) as well as the BDs in the Vieira-Poesio dataset (their results for these cases were not better than those obtained by (Vieira and Poesio, 2000)).
J00-4003
Both earlier studies such as (Poesio et al., 1997) and more recent ones (Poesio, 2003; GarciaAlmanza, 2003) had shown that mereological information in WordNet is extremely sparse.
W97-1301
These results are not as good as those obtained (by hand) by Poesio (which, however, used a complete focus tracking mechanism), but the F measure is still 66% higher than that obtained with the highest baseline (FM only), and not far off from the results obtained with direct anaphoric definite descriptions (e.g., by (Poesio and Alexandrov-Kabadjov, 2004)).
J04-3003
However, the actual anchor, the cabinet, is clearly the Backward-Looking Center (CB) (Grosz et al., 1995) of the first sentence after the title;5 and if we assume that entities can be indirectly realized– see (Poesio et al., 2004)–the cabinet is the CB of all three sentences, including the one containing the BR, and therefore a preferred candidate.
J04-3003 J95-2003
An important property of this corpus for the purpose of studying BR resolution is that fewer types of BDs are annotated than in the original Vieira / Poesio dataset, but the annotation is reliable (Poesio et al., 2004).7 The corpus also contains more mereological BDs and BRs than the original dataset used by Poesio and Vieira.
J04-3003
As already mentioned, the error analysis of Poesio et al.(1998) supported this finding: the study found that the strategy found to be optimal for anaphoric definite descriptions by Vieira and Poesio (2000), considering as equally likely all antecedents in the previous five-sentence window (as opposed to preferring closer antecedents), gave poor results for bridging references; entities introduced in the last two sentences and ‘main entities’ were clearly preferred.
J00-4003 J98-2001
(Sentences are used as utterances, as suggested by the results of (Poesio et al., 2004)).
J04-3003
Poesio et al.(1998) explored the usefulness of vector-space representations of lexical meaning for BDs that depended on lexical knowledge about hyponymy and synonymy.
J98-2001
In (Poesio, 2003), the impact on associative BD resolution of both relatively simple salience features (such as distance and order or mention) and of more complex ones (such as whether the anchor was a CB or not) was studied using the GNOME corpus (discussed below) and the CB-tracking techniques developed to compare alternative ways of instantiating 5The CB is Centering theory’s (Grosz et al., 1995) implementation of the notion of ‘topic’ or ‘main entity’.
J95-2003
sources of information for bridging reference resolution 2.1 Lexical information The use of different sources of lexical knowledge for resolving bridging references has been investigated in a series of papers by Poesio et al.all using as dataset the Bridging Descriptions (BDs) contained in the corpus used by Vieira and Poesio 3We make use of the classification of bridging references proposed by Vieira and Poesio (2000).
J00-4003
the parameters of Centering by Poesio et al.(2004). Poesio (2003) analyzed, first of all, the distance between the BD and the closest mention of the anchor, finding that of the 169 associative BDs, 77.5% had an anchor occurring either in the same sentence (59) or the previous one (72); and that only 4.2% of anchors were realized more than 5 sentences back.
J04-3003
Finally, a number of researchers recently argued for using the Web as a way of addressing data sparseness (Keller and Lapata, 2003).
J03-3005
Current and future work will also include incorporating the methods tested here in an actual anaphora resolution system, the GUITAR system (Poesio and Alexandrov-Kabadjov, 2004).
J04-3003
4A similar approach was pursued in parallel by Berland and Charniak (1999).
P99-1008
7A serious problem when working with bridging references is the fact that subjects, when asked for judgments about bridging references in general, have a great deal of difficulty in agreeing on which expressions in the corpus are bridging references, and what their anchors are (Poesio and Vieira, 1998).
J98-2001
Finally, Poesio examined the hypothesis that finding the anchor of a BD involves knowing which entities are the CB and the CP in the sense of Centering (Grosz et al., 1995).
J95-2003
work In recent years there has been a lot of work to develop anaphora resolution algorithms using both symbolic and statistical methods that could be quantitatively evaluated (Humphreys et al., 1997; Ng and Cardie, 2002) but this work focused on identity relations; bridging references were explicitly excluded from the MUC coreference task because of the problems with reliability discussed earlier.
P02-1014
Work such as (Poesio et al., 1998; Poesio et al., 2002; Poesio, 2003) provided an experimental confirmation of the hypothesis first put forward by Sidner (1979) that BRIDGING DESCRIPTIONS (BD)1 are more similar to pronouns than to other types of definite descriptions, in that they are sensitive to the local rather than the global focus (Grosz and Sidner, 1986).
J86-3001 J98-2001
Modjeska. 2003.
W03-1023
In (Poesio et al., 1997; Vieira and Poesio, 2000) WordNet 1.6 was used as a lexical resource, with poor or mediocre results.
J00-4003 W97-1301
One of the motivations behind Grosz and Sidner’s (1986) distinction between two aspects of the attentional state the LOCAL FOCUS and the GLOBAL FOCUS–is the difference between the interpretive preferences of pronouns and definite descriptions.
J86-3001
We also used the implementation of a Naive Bayes classifier included in the Weka MLL, as Modjeska et al.(2003) reported good results.
W03-1023
In the work described in this paper, we used machine learning techniques to find the best combination of local focus features and lexical distance features, focusing on MEREOLOGICAL bridging references:3 references referring to parts of an object already introduced (the cabinet), such as the panels or the top (underlined) in the following example from the GNOME corpus (Poesio et al., 2004).
J04-3003
Similar results using WordNet 1.6 were reported at around the same time by other groups e.g., (Humphreys et al., 1997; Harabagiu and Moldovan, 1998) and have been confirmed by more recent studies studying both hyponymy (Markert et al., 2003) and more specifically mereological BDs.
M98-1007
