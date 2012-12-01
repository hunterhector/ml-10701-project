In this paper, we employ an SVM-based NER method in the following way that showed good NER performance in Japanese (Isozaki and Kazawa, 2002).
C02-1054
On the other hand, in text-based NER, better results are obtained using discriminative schemes such as maximum entropy (ME) models (Borthwick, 1999; Chieu and Ng, 2003), support vector machines (SVMs) (Isozaki and Kazawa, 2002), and conditional random fields (CRFs) (McCallum and Li, 2003).
C02-1054 W03-0423 W03-0430
To deal with ASR error problems in NER, Palmer and Ostendorf (2001) proposed an HMMbased NER method that explicitly models ASR errors using ASR confidence and rejects erroneous word hypotheses in the ASR results.
H01-1034
Most previous studies of the NER of speech data used generative models such as hidden Markov models (HMMs) (Miller et al., 1999; Palmer and Ostendorf, 2001; Horlock and King, 2003b; B´echet et al., 2004; Favre et al., 2005).
H01-1034 H05-1062
Generative NER models were used for multipass ASR and NER searches using word lattices (Horlock and King, 2003b; B´echet et al., 2004; Favre et al., 2005).
H05-1062
Zhai et al.(2004) applied a text-level ME-based NER to ASR results.
N04-4010
Many discriminative methods have been applied to NER, such as decision trees (Sekine et al., 1998), ME models (Borthwick, 1999; Chieu and Ng, 2003), and CRFs (McCallum and Li, 2003).
W03-0423 W03-0430 W98-1120
Zhai et al.(2004) applied text-based NER to N-best ASR results, and merged the N-best NER results by weighted voting based on several sentence-level results such as ASR and NER scores.
N04-4010
We used the training data of the Information Retrieval and Extraction Exercise (IREX) workshop (Sekine and Eriguchi, 2000) as the text corpus, which consisted of 1,174 Japanese newspaper articles (10,718 sentences) and 18,200 NEs in eight categories (artifact, organization, location, person, date, time, money, and percent).
C00-2167
