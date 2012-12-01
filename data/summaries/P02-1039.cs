Translation In (Yamada and Knight, 2001), the translation a22 is a 1-to-1 lexical translation from an English word a111 to a foreign word a112, i.e., a106a68a4a5a22a104a8a25a7a6a113a76a114a106a92a4a97a112a115a8a111a82a6 . To allow non 1-to-1 translation, such as for idiomatic phrases or compound nouns, we extend the model as follows.
P01-1067
2 Syntax-based TM The syntax-based TM defined by (Yamada and Knight, 2001) assumes an English parse tree a15 as a channel input.
P01-1067
Similarly for the node PRP, a102a103a4a97a21a104a8a24a105a6a109a76 Pa4 right, ha a8VB-PRPa6 and a106a68a4a5a22a104a8a25a7a6a110a76 Pa4 karea8hea6 . More detailed examples are found in (Yamada and Knight, 2001).
P01-1067
A Decoder for Syntax-based Statistical MT Kenji Yamada and Kevin Knight Information Sciences Institute University of Southern California 4676 Admiralty Way, Suite 1001 Marina del Rey, CA 90292 a0 kyamada,knight a1 @isi.edu Abstract This paper describes a decoding algorithm for a syntax-based translation model (Yamada and Knight, 2001).
P01-1067
For the IBM models defined by a pioneering paper (Brown et al., 1993), a decoding algorithm based on a left-to-right search was described in (Berger et al., 1996).
J93-2003
As an overall decoding performance measure, we used the BLEU metric (Papineni et al., 2002).
P02-1040
For example, a decoder in (Och and Ney, 2000) uses alignment template statistics found in the Viterbi alignments.
P00-1056
Therefore, we are now investigating more sophisticated LMs such as (Charniak, 2001) which 8Viterbi-ratio is the ratio of the probability of the most plausible alignment with the sum of the probabilities of all the alignments.
P01-1017
Recently (Yamada and Knight, 2001) introduced a syntax-based TM which utilized syntactic structure in the channel input, and showed that it could outperform the IBM model in alignment quality.
P01-1067
Other statistical machine translation systems such as (Wu, 1997) and (Alshawi et al., 2000) also produce a tree a15 given a sentence a16 . Their models are based on mechanisms that generate two languages at the same time, so an English tree a15 is obtained as a subproduct of parsing a16 . However, their use of the LM is not mathematically motivated, since their models do not decompose into Pa4a5a2a9a8a3a10a6 and a12a14a4a5a3a7a6 unlike the noisy channel model.
J00-1004 J97-3002
