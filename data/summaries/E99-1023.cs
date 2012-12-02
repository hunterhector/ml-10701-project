(Ramshaw and Marcus, 1995) describe an error-driven transformation-based learning (TBL) method for finding NP chunks in texts.
W95-0107
(Cardie and Pierce, 1998) uses a related method but they only store POS tag sequences forming complete baseNPs.
P98-1034
(Ramshaw and Marcus, 1995) shows that baseNP recognition (Fz=I =92.0) is easier than finding both NP and VP chunks (Fz=1=88.1) and that increasing the size of the training data increases the performance on the test set.
W95-0107
The chunking classification was made by (Ramshaw and Marcus, 1995) based on the parsing information in the WSJ corpus.
W95-0107
With all but two formats IBI-IG achieves better FZ=l rates than the best published result in (Ramshaw and Marcus, 1995).
W95-0107
Ramshaw and Marcus used transformationbased learning (TBL) for developing two chunkers (Ramshaw and Marcus, 1995).
W95-0107
However, they use the (Ramshaw and Marcus, 1995) data set in a different training-test division (10-fold cross validation) which makes it (tifficult to compare their results with others.
W95-0107
It performed slightly worse on baseNP recognition than the (Ramshaw and Marcus, 1995) experiments (Fz=1=91.6).
W95-0107
We will follow (Argamon et al., 1998) and use a combination of the precision and recall rates: F~=I = (2" precision*recall) / (precision+recall).
P98-1010
The algorithm is very fast and it reaches the same performance as (Argamon et al., 1998) (F,~=1=91.6).
P98-1010
representation We have compared four complete and three partial data representation formats for the baseNP recognition task presented in (Ramshaw and Marcus, 1995).
W95-0107
We have used the optimal experiment configurations that we had obtained from the fourth experiment series for processing the complete (Ramshaw and Marcus, 1995) data set.
W95-0107
The IOB1 format, introduced in (Ramshaw and Marcus, 1995), consistently (:ame out as the best format.
W95-0107
In (Ramshaw and Marcus, 1995) a set of transformational rules is used for modifying the classification of words.
W95-0107
177 Proceedings of EACL '99 IOB1 IOB2 IOE1 IOE2 \[+\] \[+ IO IO +\] (Ramshaw and Marcus, 1995) (Veenstra, 1998) (Argamon et al., 1998) (Cardie and Pierce, 1998) accuracy 97.58% 96.50% 97.58% 96.77% 97.37% 97.2% precision 92.50% 91.24% 92.41% 91.93% 93.66% 91.47% 91.25% 91.80% 89.0% 91.6 % 90.7% recall F~=I 92.25% 92.37 92.32% 91.78 92.04% 92.23 92.46% 92.20 90.81% 92.22 92.61% 92.04 92.54% 91.89 92.27% 92.03 94.3% 91.6 91.6% 91.6 91.1% 90.9 Table 6: The F~=I scores for the (Ramshaw and Marcus, 1995) test set after training with their training data set.
P98-1010 P98-1034 W95-0107
(Argamon et al., 1998) introduce Memory-Based Sequence Learning and use it for different chunking experiments.
P98-1010
All formats 2The data described in (Ramshaw and Marcus, 1995) is available from ftp://ftp.cis.upenn.edu/pub/chunker/ 175 Proceedings of EACL '99 word/POS context chunk tag context IOB1 L=2/R=I IOB2 L--2/R=I IOE1 L=I/R=2 IOE2 L=I/R=2 \[ +\] L=2/R=I + L=0/R=2 \[ + IO L=2/R=0 + L=I/R=I IO +\] L=I/R=I+L=0/R=2 F~=I 1/2 90.12 1/0 89.30 1/2 89.55 0/1 89.73 0/0 + 0/0 89.32 0/0 + I/I 89.78 1/1 + 0/0 89.86 Table 3: Results second experiment series: the best F~=I scores for different left (L) and right (R) chunk tag context sizes for the seven representation formats using 5-fold cross-validation on section 15 of the WSJ corpus.
W95-0107
Again the best result was obtained with IOB1 (F~=I =92.37) which is an imI)rovement of the best reported F,~=1 rate for this data set ((Ramshaw and Marcus, 1995): 92.03).
W95-0107
The IBI-IG algorithm has been able to improve the best reported F2=1 rates for a stan(lar(l data set (92.37 versus (Ramshaw and Mar(:us, 1995)'s 92.03).
W95-0107
in their treatment of chunk-initial and chunk-final \[ + \] words: IOB1 IOB2 IOE1 IOE2 The first word inside a baseNP immediately following another baseNP receives a B tag (Ramshaw and Marcus, 1995).
W95-0107
~lr~l-l(; is a part of the TiMBL software package which is available from http://ilk.kub.nl 3 Results We have used the baseNP data presented in (Ramshaw and Marcus, 1995) 2.
W95-0107
We would like to apply our learning approach to the large data set mentioned in (Ramshaw and Marcus, 1995): Wall Street Journal corpus sections 2-21 as training material and section 0 as test material.
W95-0107
This time the chunker achieved a F~=l score of 93.81 which is half a point better than the results obtained by (Ramshaw and Marcus, 1995): 93.3 (other chunker rates for this data: accuracy: 98.04%; precision: 93.71%; recalh 93.90%). 4 Related work The concept of chunking was introduced by Abney in (Abney, 1991).
W95-0107
