12The mention encoding is the IOB2 encoding presented in (Tjong Kim Sang and Veenstra, 1999) and introduced by (Ramshaw and Marcus, 1994) for the task of base noun phrase chunking.
E99-1023 W94-0111
Hacioglu et al.(2005) explore the same task, investigating the performance of the AIO and the cascade model, and find that the two models have similar performance, with the AIO model having a slight advantage.
H05-1048
These features were described in (Florian et al., 2004), and are not discussed here.
N04-1001
Most systems that participated in the CoNLL 2002 and 2003 shared tasks on named entity recognition (Tjong Kim Sang, 2002; Tjong Kim Sang and De Meulder, 2003) applied this model, as they modeled the identification of mention boundaries and the assignment of mention type at the same time.
W02-2024 W03-0419
In a similar spirit to the approach presented in this article, Florian (2002) considers the task of named entity recognition as a two-step process: the first is the identification of mention boundaries and the second is the classification of the identified chunks, therefore considering a label for each word being formed from two sub-labels: one that specifies the position of the current word relative in a mention (outside any mentions, starts a mention, is inside a mention) and a label specifying the mention type . Experiments on the CoNLL’02 data show that the two-process model yields considerably higher performance.
W02-2010
Despite the above disadvantages, this model has performed well in practice: Hajic and Hladk´a (1998) applied it successfully to find POS sequences for Czech and Florian et al.(2004) reports good results on the 2003 ACE task.
N04-1001
473 and mention detection (Jing et al., 2003; Florian et al., 2004).
N04-1001 W03-1026
All experiments in this article use our in-house implementation of a maximum entropy classifier (Florian et al., 2004), which we selected because of its flexibility of integrating arbitrary types of features.
N04-1001
It turns out though, (Hacioglu, 2005) that the cascade model in (Hacioglu et al., 2005) did not change to a “mention view” sequence classification6 (as we did in Section 3.3) in the tasks following the entity detection, to allow the system to use longer range features.
H05-1048
Florian and Ngai (2001) used the same multitask learning strategy with a transformation-based learner to show that usually disjointly handled tasks perform slightly better under a joint model; the experiments there were run on POS tagging and text chunking, Chinese word segmentation and POS tagging.
W01-0701
There are cases, though, where the labels consist of several related, but not entirely correlated, properties; examples include mention detection—the task we are interested in—, syntactic parsing with functional tag assignment (besides identifying the syntactic parse, also label the constituent nodes with their functional category, as defined in the Penn Treebank (Marcus et al., 1993)), and, to a lesser extent, part-of-speech tagging in highly inflected languages.4 The particular type of mention detection that we are examining in this paper follows the ACE general definition: each mention in the text (a reference to a real-world entity) is assigned three types of information:5 • An entity type, describing the type of the entity it points to (e.g.
J93-2004
