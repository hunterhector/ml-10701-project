The optimal string under our new model is defined as w∗ = arg max w (β log Pl(w) + 〈¯α, Φ(a, w)〉+ log Pa(a|w)) (2) where the arg max is taken over all strings in the 1000-best list, and where ¯α ∈ Rd is a parameter vector specifying the “weight” for each feature in Φ (note that we define 〈x, y〉 to be the inner, or dot 1Note that (Roark et al., 2004a; Roark et al., 2004b) give results for an n-gram approach on this data which makes use of both lattices and 1000-best lists.
P04-1007
Early approaches included algorithms for efficiently calculating string prefix probabilities (Jelinek and Lafferty, 1991; Stolcke, 1995) and approaches to exploit such algorithms to produce n-gram models (Stolcke and Segal, 1994; Jurafsky et al., 1995).
J91-3004 J95-2002 P94-1011
The syntactic features provide an additional 0.3% reduction in test–set error rate beyond the model of (Roark et al., 2004a; Roark et al., 2004b) (significant at p < 0.001), which makes use of a discriminatively trained n-gram model, giving a total reduction of 1.2% over the baseline Switchboard system.
P04-1007
The Structured Language Model (Chelba and Jelinek, 1998; Chelba and Jelinek, 2000; Chelba, 2000; Xu et al., 2002; Xu et al., 2003) makes use of an incremental shift-reduce parser to enable the probability of words to be conditioned on k previous c-commanding lexical heads, rather than simply on the previous k words.
P02-1025 P98-1035 W03-1021
For example, in the experiments in Roark et al.(2004a), the perceptron converged in around 3 passes over the training set, while picking non-zero values for around 1.4 million n-gram features out of a possible 41 million n-gram features seen in the training set.
P04-1007
Similar representations have been used by (Rosenfeld et al., 2001; Wang and Harper, 2002).
W02-1031
Other work on syntactic language modeling includes that of Charniak (2001), which made use of a non-incremental, head-driven statistical parser to produce string probabilities.
P01-1017
We build on the work in Roark et al.(2004a; 2004b), which was summarized and extended in Roark et al.(2005). These papers used discriminative methods for n-gram language models.
P04-1007
As one example, the language modeling features might take into account n-grams, for example through definitions such as Φ2(a,w) = Count of the the in w Previous work (Roark et al., 2004a; Roark et al., 2004b) considered features of this type.
P04-1007
Finally, Och et al.(2004) use a reranking approach with syntactic information within a machine translation system.
N04-1021
For each utterance, 4Note that Roark et al.(2004a; 2004b; 2005) used 20854 of these utterances (249774 words) as held out data.
P04-1007
Previous work (Roark et al., 2004a; Roark et al., 2004b) has shown that discriminative methods within an ngram approach can lead to significant reductions in WER, in spite of the features being of the same type as the original language model.
P04-1007
Following Roark et al.(2004a), the parameter α1 is set to be some constant α that is typically chosen through optimization over the development set.
P04-1007
For this paper, we train the parameter vector ¯α using the perceptron algorithm (Collins, 2004; Collins, 2002).
W02-1001
Similar approaches have been described in Johnson et al.(1999) and Lafferty et al.(2001). The objective function used in optimizing the parameters is L(¯α) = summationdisplay i log P(si|ai, ¯α) − C summationdisplay j α2j (4) where P(si|ai, ¯α) = e〈Φ(ai,si),¯α〉P w∈GEN(ai) e〈Φ(ai,w),¯α〉 . Here, each si is the member of GEN(ai) which has lowest WER with respect to the target transcription wi.
P99-1069
Tree Features We tagged each candidate transcription with (1) part-of-speech tags, using the tagger documented in Collins (2002); and (2) a full parse tree, using the parser documented in Collins (1999).
W02-1001
In addition, we plan to explore the alternative parameter estimation methods described in (Roark et al., 2004a; Roark et al., 2004b), which were shown in this previous work to give further improvements over the perceptron.
P04-1007
Incremental topdown and left-corner parsing (Roark, 2001a; Roark, 2001b) and head-driven parsing (Charniak, 2001) approaches have directly used generative PCFG models as language models.
J01-2004 P01-1017
A number of results—e.g., in Sha and Pereira (2003) and Roark et al.(2004b)—suggest that the GCLM approach leads to slightly higher accuracy than the perceptron training method.
N03-1028 P04-1007
Enhancements in the feature set and improved parameter estimation techniques have extended this approach in recent years (Xu et al., 2002; Xu et al., 2003).
P02-1025 W03-1021
Linear Models We follow the framework of Collins (2002; 2004), recently applied to language modeling in Roark et al.(2004a; 2004b).
P04-1007 W02-1001
The work of Chelba and Jelinek (Chelba and Jelinek, 1998; Chelba and Jelinek, 2000; Chelba, 2000) involved the use of a shift-reduce parser trained on Penn treebank style annotations, that maintains a weighted set of parses as it traverses the string from left-to-right.
P98-1035
We briefly review the two training algorithms described in Roark et al.(2004b), the perceptron algorithm and global conditional log-linear models (GCLMs).
P04-1007
A second parameter estimation method, which was used in (Roark et al., 2004b), is to optimize the log-likelihood under a log-linear model.
P04-1007
Roark (2001a; 2001b) pursued a different derivation strategy from Chelba and Jelinek, and used the parse probabilities directly to calculate the string probabilities.
J01-2004
In the work of Wen Wang and Mary Harper (Wang and Harper, 2002; Wang, 2003; Wang et al., 2004), a constraint dependency grammar and a finite-state tagging model derived from that grammar, were used to exploit syntactic dependencies.
W02-1031
For a full description of the algorithm, see Collins (2004; 2002).
W02-1001
The experimental set-up we use is very similar to that of Roark et al.(2004a; 2004b), and the extensions to that work in Roark et al.(2005). We make use of the Rich Transcription 2002 evaluation test set (rt02) as our development set, and use the Rich Transcription 2003 Spring evaluation CTS test set (rt03) as test set.
P04-1007
In the work of Wen Wang and Mary Harper (Wang and Harper, 2002; Wang, 2003; Wang et al., 2004), a constraint dependency grammar and a finite-state tagging model derived from that grammar were used to exploit syntactic dependencies.
W02-1031
