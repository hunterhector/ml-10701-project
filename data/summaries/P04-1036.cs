We believe that an automatic means of finding a predominant sense would be useful for systems that use it as a means of backing-off (Wilks and Stevenson, 1998; Hoste et al., 2001) and for systems that use it in lexical acquisition (McCarthy, 1997; Merlo and Leybold, 2001; Korhonen, 2002) because of the limited size of hand-tagged resources.
W01-0715 W02-0907 W97-0808
We want to investigate the effect of frequency and choice of distributional similarity measure (Weeds et al., 2004).
C04-1146
It would be useful however to combine our method of finding predominant senses with one which can automatically find new senses within text and relate these to WordNet synsets, as Ciaramita and Johnson (2003) do with unknown nouns.
W03-1022
This weight is the WordNet similarity score (a4a49a10a13a28a15a28 ) between the target sense (a4a35a28a37a36 ) and the sense of a10a45a44 (a10a13a28a37a50a51a38a52a28a15a34a15a10a13a28a20a34a15a28a27a30a42a10a45a44 a33 ) that maximises this score, divided by the sum of all such WordNet similarity scores for a28a20a34a15a10a13a28a15a34a20a28a27a30a31a4 a33 and a10a46a44 . Thus we rank each sense a4a49a28 a36 a38a53a28a15a34a20a10a18a28a20a34a15a28a25a30a31a4 a33 using: a54a56a55 a34a15a57a41a58a41a59a60a34a15a10a13a61a37a34a63a62a64a61a37a65 a55 a34a27a30a31a4a35a28a37a36 a33 a8 a66 a67a69a68a32a70a27a71a73a72 a26a29a28a20a28a27a30a31a4a7a14a32a10 a44 a33a15a74 a4a49a10a13a28a20a28a27a30a31a4a35a28a37a36a42a14a32a10a46a44 a33 a75 a6a18a76a78a77a80a79 a70 a76a82a81 a67 a76a78a81a82a76a42a83a84a6a18a85 a4a35a10a13a28a15a28a25a30a31a4a49a28 a36 a79 a14a16a10a45a44 a33 (1) where: a4a49a10a13a28a20a28a27a30a31a4a35a28a37a36a86a14a16a10a45a44 a33 a8 a87a89a88a20a90 a67 a76a92a91 a70 a76a78a81 a67 a76a78a81a82a76a93a83 a67a69a68 a85 a30a42a4a49a10a13a28a15a28a25a30a31a4a35a28a37a36a42a14a32a10a13a28a37a50 a33a86a33 2.1 Acquiring the Automatic Thesaurus The thesaurus was acquired using the method described by Lin (1998).
P98-2127
The senses in WordNet are ordered according to the frequency data in the manually tagged resource SemCor (Miller et al., 1993).
H93-1061
In order to find the predominant sense of a target word we use a thesaurus acquired from automatically parsed text based on the method of Lin (1998).
P98-2127
For every pair of nouns, where each noun had a total frequency in the triple data of 10 or more, we computed their distributional similarity using the measure given by Lin (1998).
P98-2127
We are currently investigating the performance of the first sense heuristic, and this method, for other PoS on SENSEVAL-3 data (McCarthy et al., 2004), although not yet with rankings from domain specific corpora.
W04-0837
Lapata and Brew (2004) have recently also highlighted the importance of a good prior in WSD.
J04-1003
