In the original work (Brown et al., 1993) the posterior probability p(eI1|fJ1 ) is decomposed following a noisy-channel approach, but current stateof-the-art systems model the translation probability directly using a log-linear model(Och and Ney, 2002): p(eI1|fJ1 ) = exp parenleftBigsummationtextM m=1 mhm(e I1,fJ1 ) parenrightBig summationdisplay ?eI1 exp parenleftBigsummationtextM m=1 mhm(?eI1,fJ1 ) parenrightBig, (2) with hm different models, m scaling factors and the denominator a normalization factor that can be ignored in the maximization process.
J93-2003 P02-1038
Syntax-based MT approaches began with Wu (1997), who introduced the Inversion Transduction Grammars.
J97-3002
Portage is a statistical phrase-based SMT system similar to Pharaoh (Koehn et al, 2003).
N03-1017
Transduction rules between Spanish strings and English trees can be learned from a word-aligned parallel corpus with parse trees on one side (Graehl & Knight, 2004).
N04-1014
We compared our system to Pharaoh, a leading phrasal SMT decoder (Koehn et al., 2003), and our treelet system.
N03-1017
Dependency trees have been used in a variety of NLP applications, such as relation extraction (Culotta and Sorensen, 2004) and machine translation (Ding and Palmer, 2005).
P05-1067
Philipp Koehn, Franz J. Och, and Daniel Marcu. 2003. 
N03-1017
Ding and Palmer (2005) introduced a version of probabilistic extension of Synchronous Dependency Insertion Grammars (SDIG) to deal with the pervasive structure divergence.
P05-1067
We employ the phrase-based SMT framework (Koehn et al., 2003), and use the Moses toolkit (Koehn et al., 2007), and the SRILM language modelling toolkit (Stolcke, 2002), and evaluate our decoded translations using the BLEU measure (Papineni et al., 2002), using a single reference translation.
N03-1017
Factored translation with source words determining target words and CCG supertags For our experiments we used the following features: the translation probabilities Pr(sFs1 |tFt1 ) and Pr(tFt1 |sFs1 ),thelexicalweights(Koehnetal.,2003) lex(sFs1 |tFt1 ) and lex(tFt1 |sFs1 ), and a phrase penalty e, which allows the model to learn a preference for longer or shorter phrases.
N03-1017
It is an extension of Pharaoh (Koehn et al., 2003), and supports factor training and decoding.
N03-1017
A multi-target stochastic finite-state transducer is a tupleT =????...?m,Q,q0,R,F,P?? where:  is a finite set of input symbols (source vocabulary); ??...?m are m finite sets of output symbols (target vocabularies); Q is a finite set of states; q0 ?Q is the initial state; R?Q?1...?mQ is a set of transitions such as (q,w, ?p1,..., ?pm,qprime), which is a transition from the state q to the state qprime, with the source symbol w and producing the substrings (?p1,..., ?pm); P : R??[0,1] is the transition probability distribution; F : Q??[0,1] is the final state probability distribution; The probability distributions satisfy the stochastic constraint: ?q?Q (1) F(q)+ summationtext w,?p1,...,?pm,qprime P(q,w, ?p1,..., ?pm,qprime) = 1 2.2 Training the multilingual translation model Both topology and parameters of an SFST can be learned fully automatically from bilingual examples making use of underlying alignment models (Casacuberta and Vidal, 2004).
J04-2004
It also contains tools for tuning these models using minimum error rate training (Och 2003) and evaluating the resulting translations using the BLEU score (Papineni et al.2002). Moses uses standard external tools for some of the tasks to avoid duplication, such as GIZA++ (Och and Ney 2003) for word alignments and SRILM for language modeling.
P02-1038
The model based on Head-transducer was presented by Alshawi (2000).
J00-1004
Utilizing syntactic structure as the channel input was introduced into MT by Yamada (2001).
P01-1067
A monotonic segmentation copes with monotonic alignments, that is, j < k ??aj < ak following the notation of (Brown et al., 1993).
J93-2003
Based on one of the statistical models proposed by Brown et al.(1993), the basic principle of our translation model is the following: given a corpus of aligned sentences, if two words often co-occur in the source and target sentences, there is a good likelihood that they are translations of each other.
J93-2003
Och, Hermann Ney.2002 Discriminative training and maximum entropy models.
P02-1038
Named Entity Transliteration and Discovery from Multilingual Comparable Corpora, COLING-ACL, Sidney, Australia Philipp Koehn, Franz Josef Och, and Daniel Marcu, 2003.
N03-1017
Brown et al.(1993) defined a series of probabilistic translation models for MT purposes.
J93-2003
To generate phrase pairs from a parallel corpus, we use the "diag-and" phrase induction algorithm described in (Koehn et al, 2003), with symmetrized word alignments generated using IBM model 2 (Brown et al, 1993).
J93-2003 N03-1017
Jonathan Graehl Kevin Knight Training Tree Transducers In Proceedings of NAACL-HLT 2004, pages 105-112.
N04-1014
Another body of related work is the literature on word clustering in computational linguistics (Brown et al.1992; Finch 1993; Pereira, Tishby, and Lee 1993; Grefenstette 1994a) and document clustering in information retrieval (van Rijsbergen 1979; Willett 1988; Sparck-Jones 1991; Cutting et al.1992). In contrast to this earlier work, we cluster contexts or, equivalently, word tokens here, not words (or, more precisely, word types) or documents.
J93-2003
For example, ?amerika32 ??wa:Ken22?? is used as the feature of the given pair ?Ken22??and ?amerika32?? 2.5 Classification Algorithm There are several structure-based learning algorithms proposed so far (Collins and Duffy, 2001; Suzuki et al., 2003; Kudo and Matsumoto, 2004).
J03-4003
Daniel Gildea (2003) dealt with the problem of the parse tree isomorphism with a cloning operation to either tree-tostring or tree-to-tree alignment models.
P03-1011
A joint probability model, proposed by Marcu and Wong (2002), is a kind of phrasebased one.
W02-1018
Graehl and Knight (2004) described the use of tree transducers for natural language processing and addressed the training problems for this kind of transducers.
N04-1014
Niessen and Ney (2004) have used morphological decomposition to improve alignment quality.
J04-2003
Kenji Yamada and Kevin Knight 2001.
P01-1067
Work The DTSC model is different from previous work based on dependency grammars by Eisner (2003), Lin (2004), Quirk et al.(2005), Ding et al.(2005) since they all deduce dependency structures on the target side.
P05-1067
Over the last several years, various statistical syntaxbased models were proposed to extend traditional word/phrase based models in statistical machine translation (SMT) (Lin, 2004; Chiang, 2005; Ding et al., 2005; Quirk et al., 2005; Marcu et al., 2006; Liu et al., 2006).
P05-1067
Modern phrasal SMT systems such as (Koehn et al., 2003) derive much of their power from being able to memorize and use long phrases.
N03-1017
A number of alignment techniques have been proposed, varying from statistical methods (Brown et al., 1991; Gale and Church, 1991) to lexical methods (Kay and RSscheisen, 1993; Chen, 1993).
J93-2003
Phrase-based statistical machine translation (Koehn et al.2003) has emerged as the dominant paradigm in machine translation research.
N03-1017
But it has been found that phrases longer than three words have little improvement in the performance (Koehn, 2003).
N03-1017
Daniel Gildea.2003.Loosely tree based alignment for machine translation.
P03-1011
models (Och et al., 2004; Koehn et al., 2003; 
N03-1017
baseline System used for comparison was Pharaoh (Koehn et al., 2003; Koehn, 2004), which uses a beam search algorithm for decoding.
N03-1017
