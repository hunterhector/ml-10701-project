This paper only deals with nouns, however we have recently investigated the ranking method for an unsupervised predominant sense heuristic for WSD for other PoS (McCarthy et al., 2004b).
P04-1036 W04-0837
Lapata and Brew (2004) have recently used syntactic evidence to produce a prior distribution for verb senses and incorporate this in a WSD system.
J04-1003
McCarthy et al.(2004a) describe a method to produce a ranking over senses and find the predominant sense of a word just using raw text.
P04-1036 W04-0837
This weight is the WordNet similarity score (a3a42a11a14a28a30a28 ) between the target sense (a3a53a28a35a43 ) and the sense of a11a54a49 (a11a14a28a35a55a56a45a57a28a30a40a30a11a14a28a21a40a30a28a16a31a36a11a54a49a16a34 ) that maximises this score, divided by the sum of all such WordNet similarity scores for a28a30a40a21a11a19a28a21a40a30a28a26a31a32a3a41a34 and a11a50a49 . Thus we rank each sense a3a42a28 a43 a45a10a28a30a40a21a11a19a28a21a40a30a28a26a31a32a3a41a34 using:a58a41a59 a11a14a2a54a60a61a11a50a62a64a63a66a65a35a67a16a68a12a40a26a31a32a3a53a28 a43 a34a69a7 a70 a71a44a72a33a73a16a74a76a75 a27a48a28a21a28a16a31a32a3a6a15a33a11a50a49a30a34a30a77 a3a42a11a14a28a21a28a16a31a32a3a53a28a35a43a36a15a33a11a50a49a30a34 a78 a5a19a79a81a80a39a82 a73 a79a61a83 a71 a79a81a83a61a79a36a84a85a5a19a86 a3a53a11a14a28a30a28a26a31a32a3a42a28 a43 a82 a15a17a11 a49 a34 (1) where: a3a42a11a14a28a21a28a16a31a32a3a53a28a35a43a87a15a17a11a54a49a21a34a66a7 a88a46a89a21a90 a71 a79a92a91 a73 a79a81a83 a71 a79a81a83a61a79a93a84 a71a44a72 a86 a31a36a3a42a11a14a28a30a28a26a31a32a3a53a28a35a43a36a15a33a11a14a28a35a55a29a34a87a34 2.2 Acquiring the Automatic Thesaurus There are many alternative distributional similarity measures proposed in the literature, for this work we used the measure and thesaurus construction method described by Lin (1998).
P98-2127
The ranking method is described elsewhere (McCarthy et al., 2004a), but we summarise in the following section and describe how ranking scores can be used for filtering word senses.
P04-1036 W04-0837
In this paper we use an unsupervised method to rank word senses from an inventory according to prevalence (McCarthy et al., 2004a), and utilise the ranking scores to identify senses which are rare.
P04-1036 W04-0837
