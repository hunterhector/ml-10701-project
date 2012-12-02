In fact, Hirschberg and Litman (1993) found that discourse markers tend to occur at the beginning of intonational phrases, while sentential usages tend to occur midphrase.
J93-3003
Hirschberg and Litman (1993) examined how intonational information can distinguish between discourse and sentential interpretation for a set of ambiguous lexical items.
J93-3003
We have already used our POS-based model to rescore word-graphs, which results in a one percent absolute reduction in word error rate in comparison to a word-based model (Heeman 1999).
W99-0617
Bear, Dowding, and Shriberg (1992) proposed that multiple information sources need to be combined in order to detect and correct speech repairs.
P92-1008
This source is very important for repairs that do not have initial retracing, and is the mainstay of the "parser-first" approach (e.g., 550 Heeman and Allen Modeling Speakers' Utterances Dowding et al.1993)--keep trying alternative corrections until one of them parses.
P93-1008
In a test set containing 26 repairs Dowding et al.1993, they obtained a detection recall rate of 42% with a precision of 85%, and a correction recall rate of 31% with a precision of 62%.
P93-1008
Heeman and Allen 1994).
P94-1041
The literature (e.g., Bear and Price 1990; Ostendorf, Wightman, and Veilleus 1993) already indicates the usefulness of intonational information for syntactic processing.
P90-1003
However, pattern matching is too limited to capture the variety of word correspondence patterns that speech repairs exhibit (Heeman and Allen 1994).
P94-1041
Preliminary work on a Japanese corpus indicates that the model is not language specific (Heeman and Loken-Kim 1999).
W99-0617
Since speech repairs are often accompanied by word correspondences (Levelt 1983; Hindle 1983; Bear, Dowding, and Shriberg 1992; Heeman and Allen 1994; Kikui and Morimoto 1994), the actual reparandum will better predict the words in the alteration of the repair.
P83-1019 P92-1008 P94-1041
This is especially true for repairs, since their occurrence disrupts the local context that is needed to determine the POS tags (Hindle 1983).
P83-1019
In other work (Heeman 1999), we show that our POS-based model results in lower perplexity and word error rate than a word-based model.
W99-0617
To remedy the limitation of Bear, Dowding, and Shriberg (1992), we proposed that the word correspondences between the reparandum and alteration could be found by a set of well-formedness rules (Heeman and Allen 1994; Heeman, Loken-Kim, and Allen 1996).
P92-1008 P94-1041
Bear, Dowding, and Shriberg (1992) investigated the use of pattern matching of the word correspondences, global and local syntactic and semantic ill-formedness, and acoustic cues as evidence for detecting speech repairs.
P92-1008
Hindle (1983) and Kikui and Morimoto (1994) both separate the task of correcting a repair from detecting it by assuming that there is an acoustic editing signal that marks the interruption point of speech repairs (as well as access to the POS tags and utterance boundaries).
P83-1019
Bear and Price (1990) showed that a parser can use automatically extracted intonational phrasing to reduce ambiguity and improve efficiency.
P90-1003
However, there is not a reliable signal for detecting the interruption point of speech repairs (Bear, Dowding, and Shriberg 1992) nor the occurrence of intonational phrases.
P92-1008
Probably the most widely used is the presence of word correspondences between the reparandum and alteration, both at the word level and at the level of syntactic constituents (Levelt 1983; Hindle 1983; Bear, Dowding, and Shriberg 1992; Heeman and Allen 1994; Kikui and Morimoto 1994).
P83-1019 P92-1008 P94-1041
For handling word identities, one could follow the approach used for handling the POS tags (e.g., Black et al.1992; Magerman 1994) and view the POS tags and word identities as two separate sources of information.
H92-1026
Discourse markers are conjectured to give the hearer information about the discourse structure, and so aid the hearer in understanding how the new speech or text relates to what was previously said and for resolving anaphoric references (Hirschberg and Litman 1993).
J93-3003
The algorithm achieved a success rate of 85.5%, which translates into a discourse marker error rate of 37.3%, in comparison to the rate of 45.3% for Hirschberg and Litman (1993).
J93-3003
These are the same distributions that are needed by previous POS-based language models (Equation 5) and POS taggers (Church 1988; Charniak et al.1993). However, these approaches simplify the context so that the lexical probability is just conditioned on the POS category of the word, and the POS probability is conditioned on just the preceding POS tags, which leads to the following two approximations.
A88-1019
Bear, Dowding, and Shriberg 1992; Nakatani and Hirschberg 1994; O'Shaughnessy 1994; Shriberg, Bates, and Stolcke 1997).
P92-1008
Meteer and Iyer (1996) investigated whether modeling linguistic segments, segments with a single independent clause, improves language modeling.
W96-0204
Hindle 1983; Levelt 1983), as the following example illustrates.
P83-1019
In searching for the best sequence of POS tags for the transcribed words, we follow the technique proposed by Chow and Schwartz (1989) and only keep a small number of alternative paths by pruning the low probability paths after processing each word.
H89-2027
As illustrated in Figure 6, word correspondences for speech repairs tend to exhibit a cross serial dependency (Heeman and Allen 1994); in other words, if we have a correspondence between Wj in the reparandum and Wk in the alteration, any correspondence with a word in the alteration after Wk will be to a word that is after wj.
P94-1041
Dowding et al.1993) will not be robust.
P93-1008
and Discourse Marker Annotations Our POS tagset is based on the Penn tagset (Marcus, Santorini, and Marcinkiewicz 1993), but modified to include tags for discourse markers and end-of-turns, and to provide richer syntactic information (Heeman 1997).
J93-2004
Following loosely in the footsteps of the work of Hindle (1983), we divide them into the following categories: fresh starts, modification repairs, and abridged repairs.
P83-1019
To learn which ones behave similarly, Black et al.(1992) and Magerman (1994) used the clustering algorithm of Brown et al.(1992) to build a hierarchical classification tree.
H92-1026 J92-4003
