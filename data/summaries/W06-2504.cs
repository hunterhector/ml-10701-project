TiMBL: TiMBL’s results N&M: Nissim and Markert’s (2003) results ture as its highest hypernym.
P03-1008
In order to make my results as comparable as possible to Markert and Nissim’s (2002a) and Nissim and Markert’s (2003), I made two changes in the evaluation process.
P03-1008 W02-1027
Markert and Nissim’s (2002a) and Nissim and Markert’s (2003) study is the only one to approach metonymy recognition from a data-driven, statistical perspective.
P03-1008 W02-1027
First, Purandare and Pedersen (2004) defend the use of bigram features instead of simple word features.
W04-2406
I again applied this IB1-IG algorithm to Markert and Nissim’s (2002b) location corpora.
W02-1027
Such features can be expected to identify metonymies with a high precision, but since metonymies may have a wide variety of heads, performance will likely suffer from data sparseness (Nissim and Markert, 2003).
P03-1008
Like Nissim and Markert (2003), I used four measures to evaluate the experimental results: precision, recall and F-score for the metonymical category, and overall accuracy.
P03-1008
Bigrams are “ordered pairs of words that co-occur within five positions of each other” (Purandare and Pedersen, 2004, p.2) and will be used throughout this paper.
W04-2406
Sch¨utze’s (1998) approach has been implemented in the SenseClusters program (Purandare and Pedersen, 2004)2, which also incorporates some interesting variations on and extensions to the original algorithm.
W04-2406
results The experiments with grammatical information showed that TiMBL is able to replicate Nissim and Markert’s (2003) results.
P03-1008
More particularly, I will test two new approaches to metonymy recognition on the basis of Markert and Nissim’s (2002b) corpora of 1,000 mixed country names and 1,000 instances of the country name Hungary.1 The most important metonymical patterns in these corpora are place-for-people, place-for-event and place-for-product.
W02-1027
This view was first put into computational practice by Markert and Nissim (2002a).
W02-1027
On the mixed country data, Nissim and Markert’s (2003) classifiers achieved an accuracy of 87%.
P03-1008
4I again followed Purandare & Pedersen (2004) by selecting bigrams with a log-likelihood score of 3.841 or more.
W04-2406
• Should features be selected on the basis of a statistical test?4 Purandare and Pedersen (2004) used a loglikelihood test to select their features, probably because of the intuition that “candidate words whose occurrence depends on whether the ambiguous word occurs will be indicative of one of the senses of the ambiguous word and hence useful for disambiguation” (Sch¨utze, 1998, p.102).
W04-2406
Markert and Nissim (2002a) discovered that, with co-occurrence features, the reduction of window sizes from 10 to about 3 led to a radical improvement in precision (from 25% to above 50%) and recall (from 4% to above 20%).
W02-1027
However, as Markert and Nissim (2002a) argue, the sense distinctions between the literal and metonymical meanings of a word are not of a topical 3With SVD, I set the number of dimensions to 300, as in Purandare & Pedersen (2004).
W02-1027 W04-2406
In short, although the investigated unsupervised algorithms never beat the majority baseline for Markert and Nissim’s (2002b) data, they are often able to identify two clusters of data that correlate with the two possible readings.
W02-1027
