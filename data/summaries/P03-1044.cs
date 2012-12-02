Name classification is a well-studied subject, e.g., (Collins and Singer, 1999).
W99-0613
(Yangarber et al., 2000) uses an automatic but indirect evaluation of the recognizer a5 : they retrieve a test sub-set a2 a6a13 a9a12a11 a13a15a14 a2 a3 from the training corpus and manually judge the relevance of every document in a2a16a6a13 a9a17a11 a13 ; one can then obtain standard IR-style recall and precision scores for a2 a6a8a10a9a12a11 relative to a2 a6a13 a9a17a11 a13 . In presenting our results, we will discuss both kinds of evaluation.
C00-2136
One example is the algorithm for word sense disambiguation in (Yarowsky, 1995).
P95-1026
Parsing: After name classification, we apply a general English parser, from Conexor Oy, (Tapanainen and J¨arvinen, 1997).
A97-1011
The formula used for scoring candidate patterns in step 3 is similar to that in (Riloff, 1996): a1a40a39a42a41a44a43 a28a45a32a46a22a47a35a49a48 a1a51a50 a22a51a32a46a22a37a35 a52a53a54a52a56a55a30a57a59a58a61a60 a1a51a50 a22a51a32a46a22a47a35 (1) where a53 a48 a53 a32a46a22a37a35 are documents where a22 matched, and the support a1a62a50 a22a51a32a46a22a37a35 is computed as the sum of their relevance: a1a51a50 a22a51a32a46a22a37a35a49a48 a63 a64a66a65a68a67a70a69a71a73a72 a5a15a28a30a29a10a32a34a18a36a35 (2) Document relevance is computed as in (Yangarber et al., 2000) a5a15a28a30a29a10a32a34a18a74a35a75a48a76a20a78a77 a79 a71a68a65a61a80a81a69a82a64a83a72 a84 a20a78a77a86a85 a43 a28 a39 a32a46a22a37a35a12a87 (3) where a88a54a32a34a18a74a35 is the set of accepted patterns that match a18 ; this is a rough estimate of the likelihood of relevance of a18, based on the pattern accuracy measure.
C00-2136
(Strzalkowski and Wang, 1996) proposed a method for learning concepts belonging to a given semantic class.
C96-2157
(Yangarber et al., 2000) attempts to find extraction patterns, without a pre-classified corpus, starting from a set of seed patterns.
C00-2136
In co-training, learning centers on labeling a set of data-points in situations where these data-points have multiple disjoint and redundant views.8 Examples of spaces of such data-points are strings of text containing proper names, (Collins and Singer, 1999), or Web pages relevant to a query 5The seeds for Management Succession and M&A scenarios were reduced to pick up fewer than 170 documents, each.
W99-0613
Of particular relevance to our method are the algorithms for semantic classification of names or NPs described in (Thelen and Riloff, 2002; Yangarber et al., 2002).
C02-1154 W02-1028
We first present the basic algorithm for pattern acquisition, similar to that presented in (Yangarber et al., 2000).
C00-2136
the data-points in (Yangarber et al., 2002) are instances of names in text (which are to be labeled with their semantic categories), whereas here the data-points are documents; b.
C02-1154
In the absence of a good stopping criterion, the resulting list of patterns must be manually reviewed by a human; otherwise one can set ad-hoc thresholds, e.g., on the number of allowed iterations, as in (Riloff and Jones, 1999), or else to resort to supervised training to determine such thresholds—which is unsatisfactory when our 1As described in, e.g., (Riloff, 1996; Riloff and Jones, 1999; Yangarber et al., 2000).
C00-2136
(Thelen and Riloff, 2002) presents a very similar technique, in the same application as the one described in (Yangarber et al., 2002).7 However, (Thelen and Riloff, 2002) did not focus on the issue of convergence, and on leveraging negative categories to achieve or improve convergence.
C02-1154 W02-1028
For an indirect evaluation of the quality of the learned patterns, we employ the text-filtering evaluation strategy, as in (Yangarber et al., 2000).
C00-2136
(Riloff and Jones, 1999; Riloff, 1996; Yangarber et al., 2000) present different combinations of learners of patterns and concept classes specifically for IE.
C00-2136
(Yangarber et al., 2002) presents the same technique successfully applied to learning names of entities of a given semantic class, e.g., diseases or infectious agents.6 The main differences are: a.
C02-1154
