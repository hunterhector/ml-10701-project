Furthermore, to provide some assessment of the quality of the predicted orderings themselves, we follow Lapata (2003) in employing Kendall’s a7, which is a measure of how much an ordering differs from the OSO— the underlying assumption is that most reasonable sentence orderings should be fairly similar to it.
P03-1069
Table 1 presents information about article length (measured in sentences, as determined by the sentence separator of Reynar and Ratnaparkhi (1997)), vocabulary size, and token/type ratio for each domain.
A97-1004
But because we want the insertion state a1a16a20 to model digressions or unseen topics, we take the novel step of forcing its language model to be complementary to those of the other states by setting a2 a3a27a38 a21 a8 a8 a4 a8 a24 a26a11a28a30a29a6 a39a41a40a43a42a45a44a16a46 a1a48a47a1a50a49 a20 a2 a3 a26a17a21 a8a9a8 a4 a8 a24 a51a53a52a55a54a57a56 a21 a39a58a40a43a42a45a44a16a46 a1a59a47a1a50a49 a20 a2 a3a27a26a11a21a50a60 a4 a8 a24a30a24 a17 4Following Barzilay and Lee (2003), proper names, numbers and dates are (temporarily) replaced with generic tokens to help ensure that clusters contain sentences describing the same event type, rather than same actual event.
N03-1003
In recent work, Duboue and McKeown (2003) propose a method for learning a content planner from a collection of texts together with a domain-specific knowledge base, but our method applies to domains in which no such knowledge base has been supplied.
W03-1016
The usual strategy employed by domain-specific summarizers is for humans to determine a priori what types of information from the originating documents should be included (e.g., in stories about earthquakes, the number of victims) (Radev and McKeown, 1998; White et al., 2001).
H01-1054 J98-3005
Work Knowledge-rich methods Models employing manual crafting of (typically complex) representations of content have generally captured one of three types of knowledge (Rambow, 1990; Kittredge et al., 1991): domain knowledge [e.g., that earthquakes have magnitudes], domainindependent communication knowledge [e.g., that describing an event usually entails specifying its location]; and domain communication knowledge [e.g., that Reuters earthquake reports often conclude by listing previous quakes2].
W90-0112
Previous research has sought to characterize texts in terms of domain-independent rhetorical elements, such as schema items (McKeown, 1985) or rhetorical relations (Mann and Thompson, 1988; Marcu, 1997).
P97-1013
Initial topic induction As in previous work (Florian and Yarowsky, 1999; Iyer and Ostendorf, 1996; Wu and Khudanpur, 2002), we initialize the set of “topics”, distributionally construed, by partitioning all of the sentences from the documents in a given domain-specific collection into clusters.
P99-1022
By automatically annotating a large corpus of texts with discourse relations via a rhetorical parser (Marcu, 1997; Soricut and Marcu, 2003), we may be able to incorporate domain-independent relationships into the transition structure of our content models.
N03-1030 P97-1013
Knowledge-lean approaches Distributional models of content have appeared with some frequency in research on text segmentation and topic-based language modeling (Hearst, 1994; Beeferman et al., 1997; Chen et al., 1998; Florian and Yarowsky, 1999; Gildea and Hofmann, 1999; 2This does not qualify as domain knowledge because it is not about earthquakes per se.
P94-1002 P99-1022 W97-0304
We compared our results against those of a bigram language model (the baseline) and an improved version of the state-of-the-art probabilistic ordering method of Lapata (2003), both trained on the same data we used.
P03-1069
The best possible rank is 0, and the worst is a4a6a5 a40 a39 . An additional difficulty we encountered in setting up our evaluation is that while we wanted to compare our algorithms against Lapata’s (2003) state-of-the-art system, her method doesn’t consider all permutations (see below), and so the rank metric cannot be computed for it.
P03-1069
The fifth consists of narratives from the National Transportation Safety Board’s database previously employed by Jones and Thompson (2003) for event-identification experiments.
W03-0418
Formalisms exemplifying each of these knowledge types are DeJong’s (1982) scripts, McKeown’s (1985) schemas, and Rambow’s (1990) domain-specific schemas, respectively.
W90-0112
In our experiments, content models outperform Lapata’s (2003) state-of-the-art ordering method by a wide margin — for one domain and performance metric, the gap was 78 percentage points.
P03-1069
