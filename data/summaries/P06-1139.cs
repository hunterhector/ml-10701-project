HedgeTrimmera6 is our implementation of the Hedge Trimer system (Dorr et al., 2003), and Topiarya7 is our implementation of the Topiary system (Zajic et al., 2004).
W03-0501
A more common, extractive approach operates top-down, by starting from an extracted sentence that is compressed (Dorr et al., 2003) and annotated with additional information (Zajic et al., 2004).
W03-0501
This results in important savings, both in space and time, over simply running a single-source shortest-path algorithm for directed acyclic graphs (Cormen et al., 2001) over the full acceptor a57a133a31 (Soricut and Marcu, 2005).
P05-1009
When evaluated against the state-of-the-art, phrase-based decoder Pharaoh (Koehn, 2004), using the same experimental conditions – translation table trained on the FBIS corpus (7.2M Chinese words and 9.2M English words of parallel text), trigram language model trained on 155M words of English newswire, interpolation weights a65 (Equation 2) trained using discriminative training (Och, 2003) (on the 2002 NIST MT evaluation set), probabilistic beam a90 set to 0.01, histogram beam a58 set to 10 – and BLEU (Papineni et al., 2002) as our metric, the WIDL-NGLM-Aa86 a129 algorithm produces translations that have a BLEU score of 0.2570, while Pharaoh translations have a BLEU score of 0.2635.
P02-1040 P03-1021
In the worst case, one can work with simple bags of words that encode no context 1111 preferences (Soricut and Marcu, 2005).
P05-1009
In the next iteration, a88a90a89a53a91a94a93a111a95a108a97 is a singleton set containing the state POPed out from the top of a109 . The admissible heuristic function we use is the one defined in (Soricut and Marcu, 2005), using Equation 1 (unnormalized) for computing the event costs.
P05-1009
We generate WIDL-expressions from Chinese strings by exploiting a phrase-based translation table (Koehn et al., 2003).
N03-1017
The interpolation weights a65 (Equation 2) are trained using discriminative training (Och, 2003) using ROUGEa129 as the objective function, on the development set.
P03-1021
We automatically measure performance by comparing the produced headlines against one reference headline produced by a human using ROUGEa129 (Lin, 2004).
W04-1013
