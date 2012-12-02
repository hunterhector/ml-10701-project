In (Hindle, 1990), a small set of sample results are presented.
P90-1034
The measure simHinate is the same as the similarity measure proposed in (Hindle, 1990), except that it does not use dependency triples with negative mutual information.
P90-1034
The similarity measure simwN is based on the proposal in (Lin, 1997).
P97-1009
Ours is 772 similar to (Grefenstette, 1994; Hindle, 1990; Ruge, 1992) in the use of dependency relationship as the word features, based on which word similarities are computed.
P90-1034
It was shown in (Dagan et al., 1997) that a similarity-based smoothing method achieved much better results than backoff smoothing methods in word sense disambiguation.
P97-1008
In (Dagan et al., 1993) and (Pereira et al., ! 993), clusters of similar words are evaluated by how well they are able to recover data items that are removed from the input corpus one at a time.
P93-1022
Another application of automatically extracted similar words is to help solve the problem of data sparseness in statistical natural language processing (Dagan et al., 1994; Essen and Steinbiss, 1992).
P94-1038
768 2 Word Similarity Our similarity measure is based on a proposal in (Lin, 1997), where the similarity between two objects is defined to be the amount of information contained in the commonality between the objects divided by the amount of information in the descriptions of the objects.
P97-1009
We use a broad-coverage parser (Lin, 1993; Lin, 1994) to extract dependency triples from the text corpus.
C94-1079 P93-1016
In (Smadja, 1993), automatically extracted collocations are judged by a lexicographer.
J93-1007
Its value can be corn769 simgindZe(Wl, W2) = ~'~(r,w)eTCwl)NTCw2)Aresubj.of.obj-of} min(I(Wl, r, w), I(w2, r, w) ) simHindte, (Wl, W2) = ~,(r,w)eT(w,)nT(w2) min(I(wl, r, w), I(w2, r, w)) \]T(Wl)NT(w2)I simcosine(Wl,W2) = x/IZ(w~)l×lZ(w2)l 2x IT(wl)nZ(w2)l simDice(Wl, W2) = iT(wl)l+lT(w2) I simJacard (Wl, W2) = T(wl )OT(w2)l T(wl) + T(w2)l-IT(Wl)rlT(w2)l Figure 1: Other Similarity Measures puted as follows: I(w,r,w') = _ Iog(PMLE(B)PMLE(A\]B)PMLE(CIB)) --(-log PMLE(A, B, C)) log IIw,r,wfl×ll*,r,*ll -IIw,r,*ll xll*,r,w'll It is worth noting that I(w,r,w') is equal to the mutual information between w and w' (Hindle, 1990).
P90-1034
In (Alshawi and Carter, 1994), the collocations and their associated scores were evaluated indirectly by their use in parse tree selection.
J94-4005
