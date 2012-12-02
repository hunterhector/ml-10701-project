Another system similar to ours is (Purandare and Pedersen, 2004), which unfortunately was evaluated on Senseval 2 data.
W04-2406
ner. Table 4 also shows several unsupervised systems, all of which except Cymfony and (Purandare and Pedersen, 2004) participated in S3LS (check (Mihalcea et al., 2004) for further details on the systems).
W04-0807 W04-2406
More recently, the mapping has been used to test the system on publicly available benchmarks (Purandare and Ped91 Default p180 p1800 p6700 value Range Best Range Best Range Best p1 5 2-3 2 1-3 2 1-3 1 p2 10 3-4 3 2-4 3 2-4 3 p3 0.9 0.7-0.9 0.7 0.5-0.7 0.5 0.3-0.7 0.4 p4 4 4 4 4 4 4 4 p5 6 6-7 6 3-7 3 1-7 1 p6 0.8 0.5-0.8 0.6 0.4-0.8 0.7 0.6-0.95 0.95 p7 0.001 0.0005-0.001 0.0009 0.0005-0.001 0.0009 0.0009-0.003 0.001 Table 1: Parameters of the HyperLex algorithm ersen, 2004; Niu et al., 2005).
W05-0605
We include three supervised systems, the winner of S3LS (Mihalcea et al., 2004), an in-house system (kNN-all, CITATION OMITTED) which uses optimized kNN, and the same in-house system restricted to bag-of-words features only (kNN-bow), i.e. discarding other local features like bigrams or trigrams (which is what most unsupervised systems do).
W04-0807
Most of the unsupervised WSD work has been based on the vector space model (Sch¨utze, 1998; Pantel and Lin, 2002; Purandare and Pedersen, 2004), where each example is represented by a vector of features (e.g.
W04-2406
(MFS-S3) 55.0 0.98 MFS 51.5 1.0 Ciaosenso Unsup (MFS-Sc) 53.95 0.90 clr04 Unsup (MFS-Sc) 48.86 1.0 duluth-senserelate Unsup 47.48 1.0 (Purandare and Pedersen, 2004) Unsup (S2LS) Table 4: Comparison of HyperLex and MFS baseline to S3LS systems for nouns.
W04-2406
Existing handannotated corpora like SemCor (Miller et al., 1993), which is annotated with WordNet senses (Fellbaum, 1998) allow for a small improvement over the simple most frequent sense heuristic, as attested in the allwords track of the last Senseval competition (Snyder and Palmer, 2004).
H93-1061 W04-0811
In this paper we use an automatic method to map the induced senses to WordNet using hand-tagged corpora, enabling the automatic evaluation against available gold standards (Senseval 3 English Lexical Sample S3LS (Mihalcea et al., 2004)) and the automatic optimization of the free parameters of the method.
W04-0807
The system coming closer to ours is that described in (Niu et al., 2005).
W05-0605
