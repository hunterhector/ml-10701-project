They also achieve the best reported unlabeled F1 measure.8 Another positive property of this approach is that it tries to reconcile the success of distributional clustering approaches to grammar induction (Clark, 2001; Klein and Manning, 2002), with the CFG tree models in the supervised literature (Collins, 1999).
P02-1017 W01-0713
Following Klein and Manning (2004), we report unlabeled bracket precision, recall, and F1.
P04-1061
First, since we provide a set of target symbols, we can evaluate induced trees using standard labeled parsing metrics, rather than the far more forgiving unlabeled metrics described in, for example, Klein and Manning (2004).
P04-1061
There has been a great deal of work on unsupervised grammar induction, with motivations ranging from scientific interest in language acquisition to engineering interest in parser construction (Carroll and Charniak, 1992; Clark, 2001).
W01-0713
Another type of error also reported by Klein and Manning (2002) is MD VB groupings in infinitival VPs also sometimes argued by linguists (Halliday, 2004).
P02-1017
As in previous work, we begin with the part-of-speech (POS) tag sequences for each sentence rather than lexical sequences (Carroll and Charniak, 1992; Klein and Manning, 2002).
P02-1017
It is worth noting that our unlabeled F1 of 53.2 is the best reported from a primarily unsupervised system, with the next highest figure being 46.7 reported by Klein and Manning (2004).
P04-1061
This idea has been repeatedly and successfully operationalized using various kinds of distributional clustering, where we define a similarity measure between two items on the basis of their immediate left and right contexts (Sch¨utze, 1995; Clark, 2000; Klein and Manning, 2002).
P02-1017 W00-0717
Toimprovethequality of the induced trees, we combine our PCFG induction with the CCM model of Klein and Manning (2002), which has complementary stengths: it identifies brackets but does not label them.
P02-1017
Most importantly, this is the first work, to the authors’ knowl8The next highest results being 77.1 and 46.7 for English and Chinese respectively from Klein and Manning (2004).
P04-1061
The intersected model is able to learn trees with higher unlabeled F1 than those in Klein and Manning (2004).
P04-1061
One such model is the constituent-context model (CCM) of Klein and Manning (2002), a generative distributional model.
P02-1017
Similar to the approach of Klein and Manning (2004) on a different model pair, we intersect CCM and CFG+ by multiplying their scores for any labeled tree.
P04-1061
AlexanderClark. 2000.
W00-0717
Recent work has successfully induced unlabeled grammatical structure, but has not successfully learned labeled tree structure (Klein and Manning, 2002; Klein and Manning, 2004; Smith and Eisner, 2004). In this paper, our goal is to build a system capable of producing labeled parses in a target grammar with as little total effort as possible.
P02-1017 P04-1061
Klein and Manning (2002) suggest that the task of labeling constituents is significantly easier than identifying them.
P02-1017
As in Clark (2001), we characterize the distribution of a sequence by the distribution of POS tags occurring to the left and right of that sequence in a corpus.
W01-0713
Finally, weintersectthefeature-augmentedPCFGwiththe CCM model of Klein and Manning (2002), a highquality bracketing model.
P02-1017
Along the lines of Pereira and Schabes (1992), we reran the insideoutside algorithm, but this time placed zero mass on all trees which did not respect the bracketing of the gold trees.
P92-1017
