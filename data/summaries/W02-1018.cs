For example, in our previous work (Marcu, 2001), we have used a statistical translation memory of phrases in conjunction with a statistical translation model (Brown et al., 1993).
J93-2003 P01-1050
A variety of methods are used to account for the re-ordering stage: word-based (Brown et al., 1993), templatebased (Och et al., 1999), and syntax-based (Yamada and Knight, 2001), to name just a few.
J93-2003 P01-1067 W99-0604
Och and Ney (1999) learn phrase-to-phrase mappings involving word classes, which they call “templates”, and exploit them in a statistical machine translation system.
W99-0604
The decoder described in (Marcu, 2001) starts from a gloss that uses the translations in the translation memory and then tries to improve on the gloss translation by modifying it incrementally, in the style described in Section 4.
P01-1050
Unfortunately, if one works with translation models that do not allow Target words to be aligned to more than one Source word — as it is the case in the IBM models (Brown et al., 1993) — it is impossible to learn that the phrase “b c” in language S means the same thing as word “x” in language T.
J93-2003
And Marcu (2001) extracts phrase translations from automatically aligned corpora and uses them in conjunction with a word-for-word statistical translation system.
P01-1050
Most of the noisy-channel-based models used in statistical machine translation (MT) (Brown et al., 1993) are conditional probability models.
J93-2003
For each group of 100 sentences, we manually determined the number of sentences translated perfectly by the IBM model decoder of Germann et al.(2001) and the decoder that uses the joint probModel Percent perfect translations IBM Bleu score Sentence length Sentence length 6 8 10 15 20 Avg.
P01-1030
In constrast with many previous approaches (Brown et al., 1993; Och et al., 1999; Yamada and Knight, 2001), our model does not try to capture how Source sentences can be mapped into Target sentences, but rather how Source and Target sentences can be generated simultaneously.
J93-2003 P01-1067 W99-0604
For decoding, we have implemented a greedy procedure similar to that proposed by Germann et al.(2001). Given a Foreign sentence F, we first produce a gloss of it by selecting phrases in a104 a105 that maximize the probability a48 a8a31a38a39a12a41a40a49a15 . We then iteratively hillclimb by modifying E and the alignment between E and F so as to maximize the formula a48 a8a31a38a21a15 a48 a8a31a40 a0 a38a21a15 . We hillclimb by modifying an existing alignment/translation through a set of operations that modify locally the aligment/translation built until a given time.
P01-1030
The IBM Model 4 (Brown et al., 1993), for example, converges to the word alignments shown in Figure 1.b and learns the translation probabilities shown in Figure 1.a.2 Since in the IBM model one cannot link a Target word to more than a Source word, the training procedure 2To train the IBM-4 model, we used Giza (Al-Onaizan et al., 1999).
J93-2003
