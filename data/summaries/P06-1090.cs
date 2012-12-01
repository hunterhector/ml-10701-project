We did not use any reordering constraints, such as IBM constraint and ITG constraint in the search for the N-best phrase alignment (Zens et al., 2004).
C04-1030
Here, “ppicker” shows the accuracy when phrases are extracted by using the N-best phrase alignment method described in Section 4.1, while “growdiag-final” shows the accuracy when phrases are extracted using the standard phrase extraction algorithm described in (Koehn et al., 2003).
N03-1017
The translation probability is calculated from the relative frequency as, a34a35a4 a29 a0 a6 a29 a2 a8 a10 a57a59a58a22a60a62a61a64a63 a4 a29 a0a5a65 a29 a2 a8 a66a68a67 a69 a57a59a58a70a60a37a61a64a63 a4 a29 a0a5a65 a29 a2 a8 (2) where a57a59a58a22a60a62a61a64a63 a4 a29 a0a5a65 a29 a2 a8 is the frequency of alignments between the source phrase a29 a0 and the target phrase a29 a2 . (Koehn et al., 2003) used the following distortion model, which simply penalizes nonmonotonic phrase alignments based on the word distance of successively translated source phrases with an appropriate value for the parameter a71, a36a51a4a39a38 a33 a40a52a42 a33a53a45 a32 a8 a10 a71a26a72a73a25a74 a45a62a75 a74a77a76a24a78 a45 a32 a72 (3) a79a17a80a82a81a84a83a85a15a86a88a87a70a89a91a90 languageis a means communication of MG RA RA b1 b2 b3 b4 Figure 1: Phrase alignment and reordering bi-1 bi fi-1 fi ei-1 ei bi-1 bi fi-1 fi ei-1 ei bi-1 bi fi-1 fi ei-1 ei bi-1 bi fi-1 fi ei-1 ei source target target source target target source source d=MA d=MG d=RA d=RG Figure 2: Four types of reordering patterns 3 The Global Phrase Reordering Model Figure 1 shows an example of Japanese-English phrase alignment that consists of four phrase pairs.
N03-1017
Unlike previous local reordering models that emphasize the reordering of adjacent phrase pairs (Tillmann and Zhang, 2005), our model explicitly models the reordering of long distances by directly estimating the parameters from the phrase alignments of bilingual training sentences.
P05-1069
Motivated by the three-valued orientation for local reordering in (Tillmann and Zhang, 2005), we define the following four types of reordering patterns, as shown in Figure 2, a96 monotone adjacent (MA): The two source phrases are adjacent, and are in the same order as the two target phrases.
P05-1069
We used a bilingual word clustering tool, mkcls (Och et al., 1999) for this purpose.
W99-0604
We implemented our own decoder based on the algorithm described in (Ueffing et al., 2002).
W02-1021
By collapsing monotone gap and reverse gap into neutral, it can be thought of as a local reordering model similar to the block orientation bigram (Tillmann and Zhang, 2005).
P05-1069
We report results using the well-known automatic evaluation metrics Bleu (Papineni et al., 2002).
P02-1040
The consistent N-best phrase alignment can be obtained by using A* search as described in (Ueffing et al., 2002).
W02-1021
The empirically justifiable global reordering model seems to be the following, conditioned on the classes of source and target phrases: a3a27a4a39a36 a6 a57a1a0 a38a3a2a4a2a24a4 a29 a2 a33a50a8a44a65 a57a5a0 a38a6a2a7a2a7a4 a29 a0a22a33 a8 a8 (7) which is similar to the block orientation bigram (Tillmann and Zhang, 2005).
P05-1069
For comparison, we also implemented a different N-best phrase alignment method, where _ _ _ _ the_light_was_red _ _ _ the_light was_red _ _ the_light was red (1) (2) (3) Figure 4: N-best phrase alignments phrase pairs are extracted using the standard phrase extraction method described in (Koehn et al., 2003).
N03-1017
a1 Graduated in March 2006 Standard phrase-based translation systems use a word distance-based reordering model in which non-monotonic phrase alignment is penalized based on the word distance between successively translated source phrases without considering the orientation of the phrase alignment or the identities of the source and target phrases (Koehn et al., 2003; Och and Ney, 2004).
J04-4002 N03-1017
(Tillmann and Zhang, 2005) introduced the notion of a block (a pair of source and target phrases that are translations of each other), and proposed the block orientation bigram in which the local reordering of adjacent blocks are expressed as a three-valued orientation, namely Right (monotone), Left (swapped), or Neutral.
P05-1069
Here, we added the second terma3a5a4 a2 a33 a6a0 a3 a8 to cope with the asymmetry between a3a5a4 a0 a3 a6a2 a33a50a8 and a3a5a4 a2 a33 a6 a0 a3 a8 . The word translation probabilities are estimated using the GIZA++ (Och and Ney, 2003).
J03-1002
Word translation probabilities are obtained by using GIZA++ (Och and Ney, 2003).
J03-1002
The translation model used in (Koehn et al., 2003) is the product of translation probability a34a35a4 a29 a0 a33 a6 a29 a2 a33 a8 and distortion probability a36a37a4a39a38 a33a41a40a43a42a44a33a46a45 a32 a8, a3a5a4a35a29 a0 a30 a32 a6 a29 a2 a30 a32 a8 a10 a30 a47 a33a49a48 a32 a34a35a4 a29 a0a22a33 a6 a29 a2 a33a50a8 a36a51a4a39a38 a33 a40a52a42 a33a53a45 a32 a8 (1) where a38 a33 denotes the start position of the source phrase translated into the a54 -th target phrase, and a42 a33a53a45 a32 denotes the end position of the source phrase translated into the a4a53a54 a40a56a55 a8 -th target phrase.
N03-1017
