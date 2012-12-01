We present two approaches to SMT-based query expansion, both of which are implemented in the framework of phrase-based SMT (Och and Ney, 2004; Koehn et al., 2003).
J04-4002 N03-1017 P03-1021
For example, syntactic information has been deployed to reformulate questions (Hermjakob et al., 2002) or to replace questions by syntactically similar ones (Lin and Pantel, 2001); lexical ontologies such as Wordnet1 have been used to find synonyms for question words (Burke et al., 1997; Hovy et al., 2000; Prager et al., 2001; Harabagiu et al., 2001), and statistical machine translation (SMT) models trained on question-answer pairs have been used to rank candidate answers according to their translation probabilities (Berger et al., 2000; Echihabi and Marcu, 2003; Soricut and Brill, 2006).
P01-1037 P03-1003
In contrast to Bannard and Callison-Burch (2005), we applied the same inference step to infer also lexical translation probabilities pw(syn|trg) and pwprime(trg|syn) as defined in Koehn et al.(2003) for para-phrases.
N03-1017 P05-1074
as follows: p(synI1|trgI1) = ( Iproductdisplay i=1 pφ(syni|trgi)λφ (4) × pφprime(trgi|syni)λφprime × pw(syni|trgi)λw × pwprime(trgi|syni)λwprime × pd(syni,trgi)λd) × lw(synI1)λl × cφ(synI1)λc × pLM(synI1)λLM For estimation of the feature weights vectorλ defined in equation (4) we employed minimum error rate (MER) training under the BLEU measure (Och, 2003).
P03-1021
4 SMT-Based Query Expansion Our SMT-based query expansion techniques are based on a recent implementation of the phrasebased SMT framework (Koehn et al., 2003; Och and Ney, 2004).
J04-4002 N03-1017
A phrase table of paraphrases is extracted from bilingual phrase tables (Bannard and CallisonBurch, 2005), and paraphrasing quality is improved by additional discriminative training on manually created paraphrases.
P05-1074
Work QA has approached the problem of the lexical gap by various techniques for question reformulation, including rule-based syntactic and semantic reformulation patterns (Hermjakob et al., 2002), reformulations based on shared dependency parses (Lin and Pantel, 2001), or various uses of the WordNet ontology to close the lexical gap word-by-word (Hovy et al., 2000; Prager et al., 2001; Harabagiu et al., 2001).
P01-1037
The approaches that are closest to our models are the SMT approach of Radev et al.(2001) and the paraphrasing approach 465 web pages FAQ pages QA pairs count 4 billion 795,483 10,568,160 Table 1: Corpus statistics of QA pair data of Duboue and Chu-Carroll (2006).
N06-2009
Considerable improvements have been reported for the use of the local context analysis model of Xu and Croft (1996) in the QA system of Ittycheriah et al.(2001), or for the systems of Agichtein et al.(2004) or Harabagiu and Lacatusu (2004) that use FAQ data to learn how to expand query terms by answer terms.
W04-2501
Another use of natural language processing has been the deployment of SMT models on question-answer pairs for (re)ranking candidate answers which were either assumed to be contained in FAQ pages (Berger et al., 2000) or retrieved by baseline systems (Echihabi and Marcu, 2003; Soricut and Brill, 2006).
P03-1003
None of these approaches defines the problem of the lexical gap as a query expansion problem, and both approaches use much simpler SMT models than our systems, e.g., Radev et al.(2001) neglect to use a language model to aid disambiguation of translation choices, and Duboue and Chu-Carroll (2006) use SMT as black box altogether.
N06-2009
A similar picture emerges for query expansion in QA: Mixed results have been reported for wordby-word expansion based on WordNet (Burke et al., 1997; Hovy et al., 2000; Prager et al., 2001; Harabagiu et al., 2001).
P01-1037
4.2 SMT-Based Paraphrasing Our SMT-based paraphrasing system is based on the approach presented in Bannard and Callison-Burch (2005).
P05-1074
Word alignments are estimated by models similar to Brown et al.(1993). For a sequence of I phrases, the translation probability in equation (1) can be decomposed into p(fIi |eIi) = Iproductdisplay i=1 p(fi|ei) (2) Recent SMT models have shown significant improvements in translation quality by improved modeling of local word order and idiomatic expressions through the use of phrases, and by the deployment of large n-gram language models to model fluency and lexical choice.
J93-2003
