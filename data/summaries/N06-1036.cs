We evaluate our methods on the ICSI meeting recorder dialog act (MRDA) (Shriberg et al., 2004) corpus, and nd that our novel hidden backoff model can signi cantly improve dialog tagging accuracy.
W04-2319
We use the SRILM toolkit with extensions (Bilmes and Kirchhoff, 2003) to train, and use GMTK (Bilmes and Zweig, 2002) for decoding.
N03-2002
In (Ji and Bilmes, 2005), for example, an analysis of DA tagging using DBNs is performed, where the models avoid label bias by structural changes and avoid data sparseness by using a generalized backoff procedures (Bilmes and Kirchhoff, 2003).
N03-2002
Results We evaluated our hidden backoff model on the ICSI meeting recorder dialog act (MRDA) corpus (Shriberg et al., 2004).
W04-2319
In all our models, to simplify we assume that the sentence change information is known (as is common with this corpus (Shriberg et al., 2004)).
W04-2319
While clustering and annotation of these phrases is already a widely developed research topic (Pieraccini and Levin, 1991; Lee et al., 1997; Gildea and Jurafsky, 2002), in our approach we use an EM algorithm to learn these hidden sub-DAs in a data-driven fashion.
J02-3001
E. Shriberg et al.2004. The ICSI meeting recorder dialog act (MRDA) corpus.
W04-2319
We therefore have developed a procedure that allows us to train generalized backoff models (Bilmes and Kirchhoff, 2003), even when some or all of the variables involved in the model are hidden.
N03-2002
Because all variables are observed when training our baseline, we use the SRILM toolkit (Stolcke, 2002), modi ed Kneser-Ney smoothing (Chen and Goodman, 1998), and factored extensions (Bilmes and Kirchhoff, 2003).
N03-2002
First, it is rare to have subDAs labeled in training data, and indeed this is true of the corpus (Shriberg et al., 2004) that we use.
W04-2319
