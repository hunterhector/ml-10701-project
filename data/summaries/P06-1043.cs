Recent work, (McClosky et al., 2006), has shown that adding many millions of words of machine parsed and reranked LA Times articles does, in fact, improve performance of the parser on the closely related WSJ data.
N06-1020
We have already seen the results (Gildea, 2001) and (Bacchiani et al., 2006) achieve in Table 1.
W01-0521
The trends are the same as in (McClosky et al., 2006): Adding NANC data improves parsing performance on BROWN development considerably, improving the f-score from 83.9% to 86.4%.
N06-1020
While (McClosky et al., 2006) showed that this technique was effective when testing on WSJ, the true distribution was closer to WSJ so it made sense to emphasize it.
N06-1020
both the parser and reranker are built from WSJ training data) and parse the sentences from NANC with the 50-best (Charniak and Johnson, 2005) parser.
P05-1022
Examples of the sections annotated include science fiction, humor, romance, mystery, adventure, and “popular lore.” We use the same divisions as Bacchiani et al.(2006), who base their divisions on Gildea (2001).
W01-0521
In particular, we show that the reranking parser described in Charniak and Johnson (2005) improves performance of the parser on Brown to 85.2%.
P05-1022
We use the Charniak and Johnson (2005) reranking parser in our experiments.
P05-1022
The first of these, parse-reranking (Collins, 2000; Charniak and Johnson, 2005) starts with a “standard” generative parser, but uses it to generate the n-best parses rather than a single parse.
P05-1022
Lease and Charniak (2005) use the Charniak parser for biomedical data and find that the use of out-of-domain trees and in-domain vocabulary information can considerably improve performance.
P05-1022
However, the work which is most directly comparable to ours is that of (Ratnaparkhi, 1999; Hwa, 1999; Gildea, 2001; Bacchiani et al., 2006).
P99-1010 W01-0521
Steedman et al.(2003) apply cotraining to parser adaptation and find that cotraining can work across domains.
E03-1008
But the lack of corpora has led to a situation where much of the current work on parsing is performed on a single domain using training data from that domain — the Wall Street Journal (WSJ) section of the Penn Treebank (Marcus et al., 1993).
J93-2004
To use the data from NANC, we use self-training (McClosky et al., 2006).
N06-1020
Street Journal Our out-of-domain data is the Wall Street Journal (WSJ) portion of the Penn Treebank (Marcus et al., 1993) which consists of about 40,000 sentences (one million words) annotated with syntactic information.
J93-2004
The need to parse biomedical literature inspires (Clegg and Shepherd, 2005; Lease and Charniak, 2005).
P05-1022
Finally, the 1-best parses after reranking are combined with the WSJ training set to retrain the firststage parser.1 McClosky et al.(2006) find that the self-trained models help considerably when parsing WSJ.
N06-1020
Furthermore, use of the self-training techniques described in (McClosky et al., 2006) raise this to 87.8% (an error reduction of 28%) again without any use of labeled Brown data.
N06-1020
We concentrate particularly on the work of (Gildea, 2001; Bacchiani et al., 2006) as they provide results which are directly comparable to those presented in this paper.
W01-0521
Lacking alternatives, both (Gildea, 2001) and (Bacchiani et al., 2006) give up on adapting a pure WSJ trained system, instead looking at the issue of how much of an improvement one gets over a pure Brown system by adding WSJ data (as seen in the last two lines of Table 1).
W01-0521
Sekine (1997) observes that for parsing a specific domain, data from that domain is most beneficial, followed by data from the same class, data from a different class, and data from a different domain.
A97-1015
The BROWN parsing model is naturally better than the WSJ model for this task, but combining the two training corpora results in a better model (as in Gildea (2001)).
W01-0521
Thus, the WSJ+NANC model has better oracle rates than the WSJ model (McClosky et al., 2006) for both the WSJ and BROWN domains.
N06-1020
