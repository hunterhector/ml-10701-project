Verb mistagging is also a problem for other languages: Levy and Manning (2003) describe a similar problem in Chinese for noun/verb ambiguity.
P03-1056
The parsing models we present are trained and tested on the NEGRA corpus (Skut et al., 1997), a handparsed corpus of German newspaper text containing approximately 20,000 sentences.
A97-1014
POS tagging results are comparable to the best stand-alone POS taggers, achieving results of 97.1% on the test set, matching the performance of the POS tagger described by Brants (2000) When GF labels are included (e.g.
A00-1031
with Previous Work Table 4 lists the result of the best model presented here against the earlier work on NEGRA parsing described in Dubey and Keller (2003) and Schiehlen (2004).
C04-1056 P03-1013
Recent research on German statistical parsing has shown that lexicalization adds little to parsing performance in German (Dubey and Keller, 2003; Beil et al., 1999).
P03-1013 P99-1035
For both the Witten-Bell and Kneser-Ney algorithms, the λ’s are a function of the context Aa7 Bi a13 2 a7 Bi a13 1 . By contrast, in Brants’ algorithm the λ’s are constant λ1a7 λ2a7 λ3 a3 0 for each trigram x1 a4 x2 a4 x3 with ca5 x1 a4 x2 a4 x3 a6a8a7 0 d3 a3 a9 c a10 xi a11 xi a11 1a11 xi a11 2a12 a13 1 ca10 xi a11 1a11 xi a11 2a12 a13 1 if ca1 xi a13 1 a7 xi a13 2 a3a14a13 1 0 if ca1 xi a13 1 a7 xi a13 2 a3 a4 1 d2 a3 a9 c a10 xi a11 xi a11 1a12 a13 1 ca10 xi a11 1a12 a13 1 if ca1 xi a13 1a3a15a13 1 0 if ca1 xi a13 1 a3 a4 1 d1 a3 ca10 xi a12 a13 1 Na13 1 if d3 a4 max d1a7 d2a7 d3 then λ3 a3 λ3 a0 ca1 xia7 xi a13 1 a7 xi a13 2 a3 elseif d2 a4 max d1a7 d2a7 d3 then λ2 a3 λ2 a0 ca1 xia7 xi a13 1a7 xia13 2a3 else λ1 a3 λ1 a0 ca1 xia7 xi a13 1 a7 xi a13 2 a3 end λ1 a3 λ1 λ1 a16 λ2 a16 λ a16 3 λ2 a3 λ2 λ1 a16 λ2 a16 λ a16 3 λ3 a3 λ3 λ1 a16 λ2 a16 λ a16 3 Figure 1: Smoothing estimation based on the Brants (2000) approach for POS tagging.
A00-1031
Magerman. 1995.
P95-1037
The modified Witten-Bell algorithm achieved an F-score of 75.7. 4.4 Discussion Overall, the best-performing model, using Brants smoothing, achieves a labelled bracketing F-score of 76.2, higher than earlier results reported by Dubey and Keller (2003) and Schiehlen (2004).
C04-1056 P03-1013
Moreover, there are possible paths for improvement: lexicalization could be added to the model, as could some of the treebank transformations suggested by Schiehlen (2004).
C04-1056
Charniak (2000)).
A00-2018
The most common problem was verb mistagging: they are either confused with adjectives (both 2As an anonymous reviewer pointed out, it is not always straightforward to reproduce statistical parsing results even when the implementation details are given (Bikel, 2004).
J04-4004
Brants (2000) describes a POS tagger with a highly tuned suffix analyzer which considers both capitalization and suffixes as long as 10 letters long.
A00-1031
If the tags are necessary for semantic interpretation, presumably they could be re-inserted using a strategy such as that of Blaheta and Charniak (2000) The last transformation therefore removes the GF of S nodes.
A00-2018 A00-2031
Levy and Manning (2004) also present work on the NEGRA treebank, but are primarily interested in long-distance dependencies, and therefore do not report results on local dependencies, as we do here.
P04-1042
Bikel. 2004.
J04-4004
suggested different choices for Pw in the face of unknown words: Schiehlen (2004) suggests using a different unknown word token for capitalized versus uncapitalized unknown words (German orthography dictates that all common nouns are capitalized) and Levy and Manning (2004) consider inspecting the last letter the unknown word to guess the part-of-speech (POS) tags.
C04-1056 P04-1042
To allow comparisons with earlier work on NEGRA parsing, we use the same split of training, development and testing data as used in Dubey and Keller (2003).
P03-1013
We experiment with three different smoothing models: the modified Witten-Bell algorithm employed by Collins (1999), the modified Kneser-Ney algorithm of Chen and Goodman (1998) the smoothing algorithm used in the POS tagger of Brants (2000).
A00-1031
The first is a Markov context-free rule (Magerman, 1995; Charniak, 2000).
A00-2018 P95-1037
bracket scores (Magerman, 1995), with the brackets labeled by syntactic categories but not grammatical functions.
P95-1037
Rather than relying on smoothing and suffix analysis alone, we also utilize treebank transformations (Johnson, 1998; Klein and Manning, 2003) instead of a grammar induced directly from a treebank.
J98-4004 P03-1054
Re-annotation Automatic treebank transformations are an important step in developing an accurate unlexicalized parser (Johnson, 1998; Klein and Manning, 2003).
J98-4004 P03-1054
319 Model LB F-score This paper 76.3 Dubey and Keller (2003) 74.1 Schiehlen (2004) 71.1 Table 4: Comparison with previous work.
C04-1056 P03-1013
A similar improvement has been independently noted by Schiehlen (2004).
C04-1056
Given the degree of variance due to search and smoothing, it raises the question if it is in fact possible to reproduce such results without the necessary details.2 5 Error Analysis While it is uncommon to offer an error analysis for probabilistic parsing, Levy and Manning (2003) argue that a careful error classification can reveal possible improvements.
P03-1056
It is available in several formats, and in this paper, we use the Penn Treebank (Marcus et al., 1993) format of NEGRA.
J93-2004
