Mihalcea (2004) and Mihalcea and Tarau (2004) have successfully explored very similar graph representations for extractive summarization and key word extraction.
P04-3020 W04-3252
where TR(V i ) is the TextRank score for vertex i, NB(V i ) is the set of neighbors of V i, i.e. the set of nodes connected to V i by a single edge, wt xy is the weight of the edge between vertex x and vertex y, and d is a constant “dampening factor”, set at 0.85 6 . To calculate TR, an initial score of 1 is assigned to all vertices, and the formula is applied iteratively until the difference in scores between iterations falls below a threshold of 0.0001 for all vertices (as in Mihalcea and Tarau 2004).
P04-3020 W04-3252
features The TextRank metric, as described in Mihalcea and Tarau (2004) is inspired by the PageRank 21 metric which is used for web page ranking 5 . TextRank is designed to work well in text graph representations: it can take edge weights into account and it works on undirected graphs.
P04-3020 W04-3252
See also Eisner and Smith (2005) who explore this generalization for dependency parsing.
W05-1504
Mihalcea and Tarau (2004), who in turn base their default setting on Brin and Page (1998).
P04-3020 W04-3252
A term-distance based representation has been used successfully for a variety of tasks in Mihalcea (2004) and Mihalcea and Tarau (2004).
P04-3020 W04-3252
