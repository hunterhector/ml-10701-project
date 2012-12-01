Since the method was originally developed for spoken lecture segmentation, we were not able to use the same parameters as suggested in (Malioutov and Barzilay, 2006).
P06-1004
Very briefly, the TextRank system (Mihalcea and Tarau, 2004) – similar in spirit with the concurrently proposed LexRank method (Erkan and Radev, 2004) – works by building a graph representation of the text, where sentences are represented as nodes, and weighted edges are drawn using inter-sentential word overlap.
W04-3247 W04-3252
This includes systems addressing the summarization of email threads (Wan and McKeown, 2004), online discussions (Zhou and Hovy, 2005), spoken dialogue (Galley, 2006), product reviews (Hu and Liu, 2004), movie reviews (Zhuang et al., 2006), or short literary fiction stories (Kazantseva and Szpakowicz, 2006).
C04-1079 P05-1037 W06-0702
(Teufel and Moens, 1997; Hirao et al., 2002; Zhou and Hovy, 2003; D’Avanzo and Magnini, 2005).
N03-1037 P05-1037 W97-0710
While several text segmentation systems have been proposed to date, we decided to use a graphbased segmentation algorithm using normalizedcuts (Malioutov and Barzilay, 2006), shown to exceed the performance of alternative segmentation methods.
P06-1004
Note that although the MEAD distribution also includes an optional feature calculated using the LexRank graph-based algorithm (Erkan and Radev, 2004), this feature could not be used since it takes days to compute for very long documents such as ours, and thus its application was not tractable.
W04-3247
More recently, graph-based methods that rely on sentence connectivity have also been found successful, using algorithms such as node degree (Salton et al., 1997) or eigenvector centrality (Mihalcea and Tarau, 2004; Erkan and Radev, 2004; Wolf and Gibson, 2004).
P04-1049 W04-3247 W04-3252
ROUGE is a method based on Ngram statistics, found to be highly correlated with human evaluations (Lin and Hovy, 2003).1 Throughout the paper, the evaluations are reported using the ROUGE1 setting, which seeks unigram matches between the generated and the reference summaries, and which was found to have high correlation with human judgments at a 95% confidence level.
N03-1020
