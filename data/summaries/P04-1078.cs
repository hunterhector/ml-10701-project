With the introduction of the BLEU metric for machine translation evaluation (Papineni et al, 2002), the advantages of doing automatic evaluation for various NLP applications have become increasingly appreciated: they allow for faster implement-evaluate cycles (by by-passing the human evaluation bottleneck), less variation in evaluation performance due to errors in human assessor judgment, and, not least, the possibility of hill-climbing on such metrics in order to improve system performance (Och 2003).
P02-1040 P03-1021
Och. 2003.
P03-1021
The success of BLEU in doing automatic evaluation of machine translation output has often led researchers to blindly try to use this metric for evaluation tasks for which it was more or less 4 63.40 57.62 51.86 46.26 40.96 36.02 31.51 27.43 23.78 20.54 17.70 3 81.39 76.38 70.76 64.76 58.61 52.51 46.63 41.09 35.97 31.33 27.15 2 91.72 89.21 85.54 80.78 75.14 68.87 62.25 55.56 49.04 42.88 37.20 1 61.61 58.83 55.25 51.04 46.39 41.55 36.74 32.12 27.85 23.97 20.54 N/α 0 0.1 0.2 0.3 0.4 0.5 0.6 0.7 0.8 0.9 1 Table 5: R 2 for the family of metrics AEv(α,N), for correctness scores, first QA evaluation 4 79.94 79.18 75.80 70.63 64.58 58.35 52.39 46.95 42.11 37.87 34.19 3 76.15 80.44 81.19 78.45 73.07 66.27 59.11 52.26 46.08 40.68 36.04 2 67.76 77.48 84.34 86.26 82.75 75.24 65.94 56.65 48.32 41.25 35.42 1 56.55 60.81 59.60 53.56 45.38 37.40 30.68 25.36 21.26 18.12 15.69 N/α 0 0.1 0.2 0.3 0.4 0.5 0.6 0.7 0.8 0.9 1 Table 6: R 2 for the family of metrics AEv(α,N), for correctness scores, second QA evaluation appropriate (see, e.g., the paper of Lin and Hovy (2003), in which the authors start with the assumption that BLEU might work for summarization evaluation, and discover after several trials a better candidate).
N03-1020
Since metric AEv(0, 1) is almost the same as the ROUGE metric proposed by Lin and Hovy (2003) (they only differ in the stop-word list they use), our results also confirm the proposal for such metrics to be used for automatic evaluation by the Automatic Summarization community.
N03-1020
A final evaluation score for coverage was obtained using a coverage score computed as a weighted recall score (see (Lin and Hovy 2003) for more information on the human summary evaluation).
N03-1020
In this section, we focus on an evaluation carried out in order to assess the performance of a QA system for answering questions from the Frequently-Asked-Question (FAQ) domain (Soricut and Brill, 2004).
N04-1008
Recently, a second proposal for automatic evaluation has come from the Automatic Summarization community (Lin and Hovy, 2003), with an automatic evaluation metric called ROUGE, inspired by BLEU but twisted towards the specifics of the summarization task.
N03-1020
For comparison purposes, we also computed the value of R 2 for fluency using the BLEU score formula given in (Papineni et al., 2002), for the 7 systems using the same one reference, and we obtained a similar value, 78.52%; computing the value of R 2 for fluency using the BLEU scores computed with all 4 references available yielded a lower value for R 2, 64.96%, although BLEU scores obtained with multiple references are usually considered more reliable.
P02-1040
Precision-focused Family of Metrics Inspired by the work of Papineni et al.(2002) on BLEU, we define a precision-focused family of metrics, using as parameter a non-negative integer N.
P02-1040
For comparison purposes, we also computed the value of R 2 for adequacy using the BLEU score formula given in (Papineni et al., 2002), for the 7 systems using the same one reference, and we obtain a similar value, 83.91%; computing the value of R 2 for adequacy using the BLEU scores computed with all 4 references available also yielded a lower value for R 2, 62.21%. 4.2 Automatic Summarization Evaluation The Automatic Summarization evaluation carried out by NIST for the DUC 2001 conference involved 15 participating systems.
P02-1040
(See (Soricut and Brill, 2004) for more details concerning the QA task and the evaluation procedure).
N04-1008
The ROUGE metric proposed by Lin and Hovy (2003) for automatic evaluation of machineproduced summaries is part of the family of metrics RS(N), as the particular metric obtained when N=1, w n –s are 1/N, the wordiness constant W=∞, the list of stop-words SW is their own, and the stemming function ST is the one defined by the Porter stemmer (Porter 1980).
N03-1020
Recall-focused Family of Metrics As proposed by Lin and Hovy (2003), a precision-focused metric such as BLEU can be twisted such that it yields a recall-focused metric.
N03-1020
The BLEU proposed by Papineni et al.(2002) for automatic evaluation of machine translation is part of the family of metrics PS(N), as the particular metric obtained when N=4, w n –s are 1/N, the brevity constant B=1, the list of stop-words SW is empty, and the stemming function ST is the identity function.
P02-1040
