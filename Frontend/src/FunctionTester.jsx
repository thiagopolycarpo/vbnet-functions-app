
   import { useState } from 'react';

   const FunctionTester = () => {
     const [selectedFunction, setSelectedFunction] = useState('');
     const [input, setInput] = useState('');
     const [result, setResult] = useState(null);
     const [error, setError] = useState(null);

     const functions = [
       { name: 'sum-even', label: 'Sum Even Numbers', inputType: 'array' },
       { name: 'max-number', label: 'Find Max Number', inputType: 'array' },
       { name: 'count-vowels', label: 'Count Vowels', inputType: 'string' },
       { name: 'calculate-discount', label: 'Calculate Discount', inputType: 'number' },
       { name: 'reverse-array', label: 'Reverse Array', inputType: 'array' },
       { name: 'weighted-average', label: 'Weighted Average', inputType: 'weighted' },
       { name: 'has-three-consecutive', label: 'Has Three Consecutive', inputType: 'array' },
       { name: 'first-repeated', label: 'First Repeated Number', inputType: 'array' },
       { name: 'unique-numbers', label: 'Unique Numbers', inputType: 'array' },
     ];

     const handleSubmit = async (e) => {
       e.preventDefault();
       setResult(null);
       setError(null);
       try {
         let payload;
         if (selectedFunction === 'weighted-average') {
           const [notas, pesos] = input.split(';').map(s => s.split(',').map(Number));
           payload = { notas, pesos };
         } else if (selectedFunction === 'calculate-discount') {
           payload = Number(input);
         } else if (selectedFunction === 'count-vowels') {
           payload = input;
         } else {
           payload = input.split(',').map(Number);
         }
         const response = await fetch(`/api/functions/${selectedFunction}`, {
           method: 'POST',
           headers: { 'Content-Type': 'application/json' },
           body: JSON.stringify(payload),
         });
         const data = await response.json();
         if (response.ok) {
           setResult(JSON.stringify(data.result));
         } else {
           setError(data.error || `Request failed with status ${response.status}`);
         }
       } catch (err) {
         setError('Failed to fetch result: ' + err.message);
       }
     };

     return (
       <div className="max-w-2xl mx-auto">
         <h1 className="text-2xl font-bold mb-4">VB.NET Functions Tester</h1>
         <div className="mb-4">
           <label className="block text-sm font-medium mb-1">Select Function:</label>
           <select
             className="w-full p-2 border rounded"
             value={selectedFunction}
             onChange={(e) => setSelectedFunction(e.target.value)}
           >
             <option value="">Select a function</option>
             {functions.map(func => (
               <option key={func.name} value={func.name}>{func.label}</option>
             ))}
           </select>
         </div>
         {selectedFunction && (
           <div className="mb-4">
             <label className="block text-sm font-medium mb-1">
               Input {selectedFunction === 'weighted-average' ? '(notas;pesos, e.g., 7.5,8,9;2,3,5)' : 
                     selectedFunction === 'calculate-discount' ? '(number, e.g., 150)' : 
                     selectedFunction === 'count-vowels' ? '(text, e.g., Hello)' : 
                     '(numbers, e.g., 1,2,3)'}
             </label>
             <input
               type="text"
               className="w-full p-2 border rounded"
               value={input}
               onChange={(e) => setInput(e.target.value)}
               placeholder={selectedFunction === 'weighted-average' ? '7.5,8,9;2,3,5' : 
                           selectedFunction === 'calculate-discount' ? '150' : 
                           selectedFunction === 'count-vowels' ? 'Hello' : '1,2,3'}
             />
           </div>
         )}
         <button
           className="bg-blue-500 text-white px-4 py-2 rounded disabled:bg-gray-400"
           onClick={handleSubmit}
           disabled={!selectedFunction || !input}
         >
           Run
         </button>
         {result && (
           <div className="mt-4 p-4 bg-green-100 rounded">
             <strong>Result:</strong> {result}
           </div>
         )}
         {error && (
           <div className="mt-4 p-4 bg-red-100 rounded">
             <strong>Error:</strong> {error}
           </div>
         )}
       </div>
     );
   };

   export default FunctionTester;
